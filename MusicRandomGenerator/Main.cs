namespace MusicRandomGenerator
{
    public partial class Main : Form
    {
        private Dictionary<string, (int MinBPM, int MaxBPM)> genreBPMRanges;
        private Dictionary<string, List<string>> musicalKeys;

        public Main()
        {
            InitializeComponent();
            genreBPMRanges = MusicData.GenreBPMRanges;
            musicalKeys = MusicData.MusicalKeys;
        }

        public int GetBPM(string genre)
        {
            if (genreBPMRanges.TryGetValue(genre, out var bpmRange))
            {
                Random random = new Random();
                return random.Next(bpmRange.MinBPM, bpmRange.MaxBPM + 1);
            }
            else
            {
                throw new ArgumentException("Genre not found");
            }
        }

        private List<string> GenerateChordProgression(List<string> notesInKey)
        {
            var possibleProgressions = new List<List<string>>
            {
                new List<string> { "I", "IV", "V", "I" },
                new List<string> { "I", "V", "vi", "IV" },
                new List<string> { "ii", "V", "I", "vi" },
                new List<string> { "I", "vi", "IV", "V" },
                new List<string> { "I", "IV", "ii", "V" }
            };

            Random random = new Random();
            var selectedProgression = possibleProgressions[random.Next(possibleProgressions.Count)];

            var chords = new List<string>();

            foreach (var degree in selectedProgression)
            {
                switch (degree)
                {
                    case "I":
                        chords.Add(notesInKey[0] + " Major");
                        break;
                    case "ii":
                        chords.Add(notesInKey[1] + " Minor");
                        break;
                    case "IV":
                        chords.Add(notesInKey[3] + " Major");
                        break;
                    case "V":
                        chords.Add(notesInKey[4] + " Major");
                        break;
                    case "vi":
                        chords.Add(notesInKey[5] + " Minor");
                        break;
                }
            }

            return chords;
        }

        private string GenerateChordsDisplay(List<string> chordProgression, List<string> notesInKey)
        {
            var chordsDisplay = new List<string>();

            foreach (var chord in chordProgression)
            {
                var rootNote = chord.Split(' ')[0];
                var chordType = chord.Split(' ')[1];

                List<string> chordNotes;
                int rootIndex = notesInKey.IndexOf(rootNote);

                if (chordType == "Major")
                {
                    chordNotes = new List<string>
                    {
                        rootNote,
                        notesInKey[(rootIndex + 2) % notesInKey.Count],
                        notesInKey[(rootIndex + 4) % notesInKey.Count]
                    };
                }
                else if (chordType == "Minor")
                {
                    chordNotes = new List<string>
                    {
                        rootNote,
                        notesInKey[(rootIndex + 2) % notesInKey.Count],
                        notesInKey[(rootIndex + 3) % notesInKey.Count]
                    };
                }
                else
                {
                    chordNotes = new List<string>();
                }

                chordsDisplay.Add($"{chord}: {string.Join(", ", chordNotes)}");
            }
            return string.Join(Environment.NewLine, chordsDisplay);
        }

        private string GenerateMelody(List<string> chordProgression, List<string> notesInKey)
        {
            var melodyLines = new List<string>();
            int beatsPerBar = 8;
            int totalBars = 4;
            Random random = new Random();

            foreach (var note in notesInKey)
            {
                string noteLabel = note.Length == 1 ? $"{note} : " : $"{note}: ";
                melodyLines.Add(noteLabel);
            }

            for (int bar = 0; bar < totalBars; bar++)
            {
                for (int beat = 0; beat < beatsPerBar; beat++)
                {
                    bool notePlaced = false;
                    string noteToPlay = null;

                    if (random.NextDouble() > 0.5)
                    {
                        noteToPlay = notesInKey[random.Next(notesInKey.Count)];
                        int noteIndex = notesInKey.IndexOf(noteToPlay);

                        melodyLines[noteIndex] += "o ";
                        notePlaced = true;
                    }

                    for (int i = 0; i < melodyLines.Count; i++)
                    {
                        if (!notePlaced || i != notesInKey.IndexOf(noteToPlay))
                        {
                            melodyLines[i] += ". ";
                        }
                    }
                }

                for (int i = 0; i < melodyLines.Count; i++)
                {
                    melodyLines[i] += "| ";
                }
            }

            for (int i = 0; i < melodyLines.Count; i++)
            {
                melodyLines[i] = melodyLines[i].TrimEnd('|', ' ');
            }

            return string.Join(Environment.NewLine, melodyLines);
        }

        private string GenerateRandomVibe()
        {
            var adjectives = MusicData.Adjectives;

            Random random = new Random();
            string adjective1 = adjectives[random.Next(adjectives.Count)];
            string adjective2 = adjectives[random.Next(adjectives.Count)];

            while (adjective1 == adjective2)
            {
                adjective2 = adjectives[random.Next(adjectives.Count)];
            }

            adjective1 = char.ToUpper(adjective1[0]) + adjective1.Substring(1);
            adjective2 = char.ToUpper(adjective2[0]) + adjective2.Substring(1);

            return $"{adjective1}-{adjective2}";
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            melodyTxt.Text = "";
            Random random = new Random();
            var randomGenre = genreBPMRanges.Keys.ElementAt(random.Next(genreBPMRanges.Count));

            int bpm = GetBPM(randomGenre);

            var randomKey = musicalKeys.Keys.ElementAt(random.Next(musicalKeys.Count));
            var notesInKey = musicalKeys[randomKey];

            genreTxt.Text = randomGenre;
            bpmTxt.Text = bpm.ToString();
            keyTxt.Text = randomKey;
            notesTxt.Text = string.Join(", ", notesInKey);

            var chordProgression = GenerateChordProgression(notesInKey);
            progTxt.Text = string.Join(" - ", chordProgression);

            chordTxt.Text = GenerateChordsDisplay(chordProgression, notesInKey);

            vibeTxt.Text = GenerateRandomVibe();
        }

        private void makeMelodyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var notesInKey = notesTxt.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var chordProgression = progTxt.Text.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                melodyTxt.Text = GenerateMelody(chordProgression, notesInKey);
            }
            catch
            {
                MessageBox.Show("Please generate a chord progression first.");
            }
        }
    }
}