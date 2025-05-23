﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRandomGenerator
{
    public static class MusicData
    {
        public static Dictionary<string, (int MinBPM, int MaxBPM)> GenreBPMRanges { get; } = new Dictionary<string, (int MinBPM, int MaxBPM)>
        {
            { "House", (115, 130) },
            { "Deep House", (120, 125) },
            { "Tech House", (120, 130) },
            { "Progressive House", (125, 130) },
            { "Electro House", (128, 132) },
            { "Trance", (130, 140) },
            { "Progressive Trance", (128, 135) },
            { "Psytrance", (140, 150) },
            { "Dubstep", (140, 150) },
            { "Drum and Bass", (160, 180) },
            { "Techno", (120, 150) },
            { "Minimal Techno", (120, 128) },
            { "Hardstyle", (140, 150) },
            { "Trap", (140, 160) },
            { "Future Bass", (130, 150) },
            { "Chillout", (90, 120) },
            { "Ambient", (60, 90) },
            { "Glitch Hop", (110, 115) },
            { "Moombahton", (108, 115) },
            { "Tropical House", (100, 115) },
            { "Big Room", (126, 132) },
            { "Hardcore", (160, 200) },
            { "Jungle", (160, 180) },
            { "UK Garage", (130, 135) },
            { "Bassline", (135, 142) },
            { "Footwork", (150, 160) },
            { "Jersey Club", (130, 140) },
            { "Future Garage", (130, 135) },
            { "Synthwave", (80, 118) },
            { "Vaporwave", (60, 90) },
            { "Electro Swing", (110, 125) },
            { "Breakbeat", (125, 140) },
            { "IDM", (60, 160) },
            { "Gabber", (180, 200) },
            { "Speedcore", (200, 300) },
            { "Darkstep", (160, 180) },
            { "Neurofunk", (160, 180) },
            { "Liquid Funk", (160, 180) },
            { "Jump Up", (170, 180) },
            { "Riddim", (140, 150) },
            { "Brostep", (140, 150) },
            { "Complextro", (128, 130) },
            { "Fidget House", (128, 132) },
            { "Melbourne Bounce", (128, 130) },
            { "Future House", (120, 128) },
            { "Bass House", (126, 132) },
            { "Ghetto House", (130, 135) },
            { "Chicago House", (120, 130) },
            { "Detroit Techno", (120, 135) },
            { "Acid Techno", (130, 150) },
            { "Hard Techno", (140, 150) },
            { "Phonk", (130, 150) },
            { "Drift Phonk", (140, 160) },
            { "Lo-fi", (60, 90) },
            { "Downtempo", (70, 100) },
            { "Chiptune", (120, 150) },
            { "8-bit", (120, 150) },
            { "Electroclash", (120, 130) },
            { "Nu Disco", (120, 125) },
            { "Italo Disco", (120, 130) },
            { "Space Disco", (120, 130) },
            { "French House", (110, 125) },
            { "Nu Jazz", (120, 130) },
            { "Electro Pop", (110, 130) },
            { "Synth Pop", (110, 130) },
            { "New Wave", (120, 140) },
            { "Dark Wave", (110, 130) },
            { "Cold Wave", (110, 130) },
            { "Minimal Wave", (110, 130) },
            { "Dream Pop", (60, 100) },
        };

        public static Dictionary<string, List<string>> MusicalKeys { get; } = new Dictionary<string, List<string>>
        {
            { "C Major", new List<string> { "C", "D", "E", "F", "G", "A", "B" } },
            { "A Minor", new List<string> { "A", "B", "C", "D", "E", "F", "G" } },
            { "G Major", new List<string> { "G", "A", "B", "C", "D", "E", "F#" } },
            { "E Minor", new List<string> { "E", "F#", "G", "A", "B", "C", "D" } },
            { "D Major", new List<string> { "D", "E", "F#", "G", "A", "B", "C#" } },
            { "B Minor", new List<string> { "B", "C#", "D", "E", "F#", "G", "A" } },
            { "A Major", new List<string> { "A", "B", "C#", "D", "E", "F#", "G#" } },
            { "F# Minor", new List<string> { "F#", "G#", "A", "B", "C#", "D", "E" } },
            { "E Major", new List<string> { "E", "F#", "G#", "A", "B", "C#", "D#" } },
            { "C# Minor", new List<string> { "C#", "D#", "E", "F#", "G#", "A", "B" } },
            { "B Major", new List<string> { "B", "C#", "D#", "E", "F#", "G#", "A#" } },
            { "G# Minor", new List<string> { "G#", "A#", "B", "C#", "D#", "E", "F#" } },
            { "F# Major", new List<string> { "F#", "G#", "A#", "B", "C#", "D#", "E#" } },
            { "D# Minor", new List<string> { "D#", "E#", "F#", "G#", "A#", "B", "C#" } },
            { "C# Major", new List<string> { "C#", "D#", "E#", "F#", "G#", "A#", "B#" } },
            { "A# Minor", new List<string> { "A#", "B#", "C#", "D#", "E#", "F#", "G#" } },
            { "F Major", new List<string> { "F", "G", "A", "Bb", "C", "D", "E" } },
            { "D Minor", new List<string> { "D", "E", "F", "G", "A", "Bb", "C" } },
            { "Bb Major", new List<string> { "Bb", "C", "D", "Eb", "F", "G", "A" } },
            { "G Minor", new List<string> { "G", "A", "Bb", "C", "D", "Eb", "F" } },
            { "Eb Major", new List<string> { "Eb", "F", "G", "Ab", "Bb", "C", "D" } },
            { "C Minor", new List<string> { "C", "D", "Eb", "F", "G", "Ab", "Bb" } },
            { "Ab Major", new List<string> { "Ab", "Bb", "C", "Db", "Eb", "F", "G" } },
            { "F Minor", new List<string> { "F", "G", "Ab", "Bb", "C", "Db", "Eb" } },
            { "Db Major", new List<string> { "Db", "Eb", "F", "Gb", "Ab", "Bb", "C" } },
            { "Bb Minor", new List<string> { "Bb", "C", "Db", "Eb", "F", "Gb", "Ab" } },
            { "Gb Major", new List<string> { "Gb", "Ab", "Bb", "Cb", "Db", "Eb", "F" } },
            { "Eb Minor", new List<string> { "Eb", "F", "Gb", "Ab", "Bb", "Cb", "Db" } },
            { "Cb Major", new List<string> { "Cb", "Db", "Eb", "Fb", "Gb", "Ab", "Bb" } },
            { "Ab Minor", new List<string> { "Ab", "Bb", "Cb", "Db", "Eb", "Fb", "Gb" } },
            { "C Dorian", new List<string> { "C", "D", "Eb", "F", "G", "A", "Bb" } },
            { "D Dorian", new List<string> { "D", "E", "F", "G", "A", "B", "C" } },
            { "E Dorian", new List<string> { "E", "F#", "G", "A", "B", "C#", "D" } },
            { "F Dorian", new List<string> { "F", "G", "Ab", "Bb", "C", "D", "Eb" } },
            { "G Dorian", new List<string> { "G", "A", "Bb", "C", "D", "E", "F" } },
            { "A Dorian", new List<string> { "A", "B", "C", "D", "E", "F#", "G" } },
            { "B Dorian", new List<string> { "B", "C#", "D", "E", "F#", "G#", "A" } },
            { "C Phrygian", new List<string> { "C", "Db", "Eb", "F", "G", "Ab", "Bb" } },
            { "D Phrygian", new List<string> { "D", "Eb", "F", "G", "A", "Bb", "C" } },
            { "E Phrygian", new List<string> { "E", "F", "G", "A", "B", "C", "D" } },
            { "F Phrygian", new List<string> { "F", "Gb", "Ab", "Bb", "C", "Db", "Eb" } },
            { "G Phrygian", new List<string> { "G", "Ab", "Bb", "C", "D", "Eb", "F" } },
            { "A Phrygian", new List<string> { "A", "Bb", "C", "D", "E", "F", "G" } },
            { "B Phrygian", new List<string> { "B", "C", "D", "E", "F#", "G", "A" } },
            { "C Lydian", new List<string> { "C", "D", "E", "F#", "G", "A", "B" } },
            { "D Lydian", new List<string> { "D", "E", "F#", "G#", "A", "B", "C#" } },
            { "E Lydian", new List<string> { "E", "F#", "G#", "A#", "B", "C#", "D#" } },
            { "F Lydian", new List<string> { "F", "G", "A", "B", "C", "D", "E" } },
            { "G Lydian", new List<string> { "G", "A", "B", "C#", "D", "E", "F#" } },
            { "A Lydian", new List<string> { "A", "B", "C#", "D#", "E", "F#", "G#" } },
            { "B Lydian", new List<string> { "B", "C#", "D#", "E#", "F#", "G#", "A#" } },
            { "C Mixolydian", new List<string> { "C", "D", "E", "F", "G", "A", "Bb" } },
            { "D Mixolydian", new List<string> { "D", "E", "F#", "G", "A", "B", "C" } },
            { "E Mixolydian", new List<string> { "E", "F#", "G#", "A", "B", "C#", "D" } },
            { "F Mixolydian", new List<string> { "F", "G", "A", "Bb", "C", "D", "Eb" } },
            { "G Mixolydian", new List<string> { "G", "A", "B", "C", "D", "E", "F" } },
            { "A Mixolydian", new List<string> { "A", "B", "C#", "D", "E", "F#", "G" } },
            { "B Mixolydian", new List<string> { "B", "C#", "D#", "E", "F#", "G#", "A" } },
            { "C Aeolian", new List<string> { "C", "D", "Eb", "F", "G", "Ab", "Bb" } },
            { "D Aeolian", new List<string> { "D", "E", "F", "G", "A", "Bb", "C" } },
            { "E Aeolian", new List<string> { "E", "F#", "G", "A", "B", "C", "D" } },
            { "F Aeolian", new List<string> { "F", "G", "Ab", "Bb", "C", "Db", "Eb" } },
            { "G Aeolian", new List<string> { "G", "A", "Bb", "C", "D", "Eb", "F" } },
            { "A Aeolian", new List<string> { "A", "B", "C", "D", "E", "F", "G" } },
            { "B Aeolian", new List<string> { "B", "C#", "D", "E", "F#", "G", "A" } },
            { "C Locrian", new List<string> { "C", "Db", "Eb", "F", "Gb", "Ab", "Bb" } },
            { "D Locrian", new List<string> { "D", "Eb", "F", "G", "Ab", "Bb", "C" } },
            { "E Locrian", new List<string> { "E", "F", "G", "A", "Bb", "C", "D" } },
            { "F Locrian", new List<string> { "F", "Gb", "Ab", "Bb", "Cb", "Db", "Eb" } },
            { "G Locrian", new List<string> { "G", "Ab", "Bb", "C", "Db", "Eb", "F" } },
            { "A Locrian", new List<string> { "A", "Bb", "C", "D", "Eb", "F", "G" } },
            { "B Locrian", new List<string> { "B", "C", "D", "E", "F", "G", "A" } }
        };

        public static List<string> Adjectives { get; } = new List<string>
        {
            "abundant", "accurate", "adorable", "agile", "alert", "ancient", "angry", "anxious", "arrogant", "ashamed", "attractive", "average", "awful", "beautiful", "better", "bewildered", "big", "bitter", "black", "blue", "bold", "bored", "brave", "brief", "bright", "broad", "broken", "busy", "calm", "careful", "charming", "cheap", "cheerful", "clean", "clear", "clever", "cloudy", "clumsy", "cold", "colorful", "comfortable", "common", "complex", "confident", "confused", "cool", "cooperative", "courageous", "crazy", "creepy", "crisp", "cruel", "curious", "cute", "damaged", "damp", "dangerous", "dark", "dead", "deafening", "deep", "defeated", "defiant", "delicious", "delightful", "depressed", "determined", "different", "difficult", "dirty", "dizzy", "doubtful", "drab", "dry", "dull", "eager", "early", "easy", "elated", "elegant", "embarrassed", "empty", "encouraging", "energetic", "enthusiastic", "envious", "evil", "excited", "expensive", "exuberant", "fair", "faithful", "famous", "fancy", "fantastic", "fast", "fat", "fearless", "fierce", "filthy", "fine", "foolish", "fragile", "frail", "free", "friendly", "frightened", "funny", "fuzzy", "gentle", "giant", "gigantic", "glamorous", "gleaming", "gloomy", "glorious", "good", "gorgeous", "graceful", "grieving", "grotesque", "grumpy", "handsome", "happy", "hard", "harsh", "healthy", "helpful", "helpless", "hilarious", "hollow", "homeless", "homely", "horrible", "hot", "huge", "hungry", "hurt", "icy", "idealistic", "ill", "imaginative", "immense", "impartial", "important", "impossible", "impressive", "incredible", "industrious", "inexpensive", "infamous", "innocent", "inquisitive", "intelligent", "interesting", "itchy", "jealous", "jittery", "jolly", "joyful", "joyous", "juicy", "jumpy", "kind", "lazy", "light", "lively", "lonely", "long", "loose", "loud", "lovely", "lucky", "magnificent", "massive", "mature", "mean", "messy", "mighty", "miniature", "modern", "moist", "motionless", "muddy", "mysterious", "narrow", "nasty", "naughty", "nervous", "new", "nice", "noisy", "nutritious", "obedient", "obnoxious", "odd", "old", "optimistic", "ordinary", "outrageous", "outstanding", "panicky", "perfect", "plain", "pleasant", "poised", "polite", "poor", "powerful", "precious", "prickly", "proud", "pungent", "puny", "quaint", "quick", "quiet", "quirky", "quizzical", "radiant", "rainy", "rapid", "rare", "ratty", "reassuring", "relieved", "repulsive", "responsible", "rich", "ripe", "robust", "rotten", "rough", "round", "rude", "salty", "sarcastic", "sassy", "satisfied", "scary", "scattered", "scrawny", "selfish", "serious", "shaggy", "shaky", "shallow", "sharp", "shiny", "short", "shy", "silly", "skinny", "sleepy", "slimy", "slippery", "slow", "small", "smart", "smelly", "smiling", "smoggy", "smooth", "soft", "soggy", "solid", "sore", "sour", "sparkling", "spectacular", "spicy", "splendid", "spotless", "spotted", "square", "squeaky", "stale", "steep", "sticky", "stormy", "strange", "strong", "stunning", "stupid", "successful", "sudden", "super", "sweet", "swift", "talented", "tame", "tasty", "tender", "tense", "terrible", "thankful", "thoughtful", "thoughtless", "thundering", "tight", "timid", "tired", "tough", "troubled", "ugliest", "ugly", "uninterested", "unsightly", "unusual", "upset", "uptight", "vast", "victorious", "violent", "vivacious", "wandering", "warm", "weary", "wet", "whimsical", "whiny", "white", "wicked", "wide", "wild", "witty", "wobbly", "wonderful", "worried", "worrisome", "wrong", "yawning", "yellow", "young", "yummy", "zany", "zealous", "zesty", "goopy", "abrasive", "abrupt", "absurd", "abysmal", "accessible", "acclaimed", "aching", "acrobatic", "adamant", "addicted", "adept", "adhesive", "admired", "adolescent", "advanced", "affable", "affectionate", "aggravated", "agreeable", "aimless", "airy", "ajar", "alarming", "altruistic", "amateur", "amazing", "ambiguous", "ambitious", "amiable", "ample", "amused", "amusing", "ancient", "angelic", "apathetic", "apprehensive", "appropriate", "apt", "arctic", "articulate", "artistic", "ashamed", "aspiring", "astonishing", "athletic", "attentive", "authentic", "authorized", "automatic", "available", "avaricious", "average", "aware", "awesome", "awestruck", "awkward", "babyish", "back", "bad-tempered", "baggy", "bare", "barren", "bashful", "beady", "beaming", "belated", "beloved", "beneficial", "bewitched", "biodegradable", "biological", "bland", "blank", "blaring", "blissful", "blonde", "blotchy", "blunt", "blurry", "boiling", "boisterous", "bony", "bossy", "bouncy", "bountiful", "brazen", "breakable", "breezy", "brief", "brilliant", "brisk", "bubbly", "bulky", "bumpy", "buoyant", "burdensome", "burly", "bustling", "buzzing", "candid", "canine", "capable", "carefree", "careless", "caring", "cautious", "cavernous", "ceaseless", "cerebral", "chapped", "charming", "chaste", "chattering", "cheeky", "cheesy", "chic", "chilly", "chivalrous", "choosy", "chubby", "circular", "clammy", "classic", "cluttered", "coarse", "cocky", "coherent", "colossal", "compact", "compassionate", "competent", "complacent", "composed", "concerned", "condemned", "conflicted", "conscious", "considerate", "content", "conventional", "cooing", "corrupt", "costly", "crafty", "cramped", "creaky", "credible", "crimson", "crispy", "critical", "crooked", "cuddly", "cultured", "cumbersome", "curly", "cursed", "curved", "cushy", "cynical", "dandy", "dapper", "daring", "darling", "dashing", "dazzling", "deadpan", "deaf", "decent", "decisive", "decorative", "deep-rooted", "defensive", "deficient", "delectable", "delicate", "dependable", "descriptive", "deserted", "desperate", "detailed", "determined", "devoted", "didactic", "digital", "diligent", "dim", "dingy", "direct", "disastrous", "discreet", "disguised", "disloyal", "dismal", "distant", "distinct", "distorted", "dizzying", "dopey", "doting", "double", "downcast", "downtown", "dreary", "droopy", "drowsy", "drunk", "dry-rotted", "dual", "dubious", "ducky", "dumb", "dutiful", "earthy", "easygoing", "eclectic", "ecstatic", "edgy", "edible", "educated", "effervescent", "efficient", "elaborate", "elastic", "elated", "elderly", "electric", "elevated", "elusive", "embellished", "emotional", "empathetic", "empowered", "enchanting", "encouraged", "endangered", "endearing", "endless", "energetic", "engaged", "engaging", "enlightened", "enraged", "entertaining", "enthused", "equable", "equal", "equitable", "erratic", "essential", "esteemed", "ethical", "euphoric", "even", "everlasting", "evident", "evil-minded", "exact", "exalted", "exasperated", "excellent", "excitable", "exclusive", "exotic", "expectant", "experienced", "expert", "extra", "extraneous", "extraordinary", "exuberant", "faint", "fair-minded", "fake", "familiar", "fancy", "fantastical", "farsighted", "fatal", "favorable", "fearful", "feeble", "festive", "fidgety", "filmy", "final", "firm", "fiscal", "flaky", "flashy", "flawless", "flickering", "flimsy", "flirtatious", "flowery", "fluffy", "fluid", "fluttering", "focused", "foolhardy", "forceful", "formal", "forthright", "fortunate", "foul", "fractured", "fragile", "frantic", "frayed", "freezing", "frequent", "fresh", "friendly", "frightening", "frilly", "frisky", "frosty", "frozen", "frugal", "fruitful", "frustrated", "fuchsia", "full", "fumbling", "functional", "fun-loving", "furious", "furry", "fussy", "fuzzy", "gargantuan", "gaseous", "gaudy", "generous", "gentlemanly", "ghastly", "ghostly", "ghoulish", "gleeful", "glib", "global", "glossy", "glowing", "gnarled", "godly", "golden", "gooey", "gorgeous", "graceful", "gracious", "grainy", "grand", "granular", "grateful", "gratifying", "greasy", "greedy", "greenish", "gregarious", "grimy", "gripping", "gritty", "groggy", "gruesome", "guilty", "gullible", "gusty", "guttural", "habitual", "hairless", "hairy", "half", "handmade", "handy", "haphazard", "hardy", "hasty", "hateful", "haunting", "headstrong", "healing", "heartfelt", "hearty", "heavenly", "hectic", "heinous", "helping", "heroic", "hidden", "high-pitched", "hilarious", "hoarse", "hollow", "homemade", "hopeful", "hospitable", "hostile", "hot-headed", "huge-hearted", "humble", "humdrum", "humid", "humiliated", "humorous", "hungry", "hurried", "husky", "icy", "ideal", "idiotic", "idle", "ignorant", "ill-tempered", "illegal", "illicit", "illuminated", "illusory", "imaginary", "imaginative", "immaculate", "immature", "immeasurable", "immense", "imminent", "immune", "impassable", "impatient", "imperfect", "impish", "impolite", "important", "imposing", "impractical", "impressed", "impure", "inaccurate", "inactive", "inadequate", "inappropriate", "incandescent", "incapable", "incessant", "incoherent", "incompetent", "incredible", "independent", "indigo", "industrious", "inebriated", "inefficient", "inept", "infamous", "inferior", "infuriated", "ingenious", "ingrained", "initial", "injured", "innate", "inoffensive", "insecure", "insightful", "insipid", "instant", "insubstantial", "intense", "intentional", "interactive", "interesting", "internal", "intolerable", "intuitive", "invincible", "invisible", "involved", "irate", "irregular", "irrelevant", "irresistible", "irritated", "itchy", "jaded", "jagged", "jam-packed", "jaunty", "jeering", "jerky", "jocund", "joint", "jovial", "joyous", "jubilant", "judicious", "juicy", "jumbo", "jumpy", "junior", "just", "keen", "key", "kindhearted", "klutzy", "knavish", "knobby", "kooky", "kosher", "lame", "lanky", "lavish", "lawful", "lax", "leafy", "learned", "leathery", "left", "legal", "legitimate", "lengthy", "lesser", "lethal", "level", "lighthearted", "likeable", "limp", "limping", "linear", "literate", "lively", "loathsome", "logical", "lonesome", "longing", "loopy", "loose-fitting", "lopsided", "lost", "loudmouthed", "loveless", "lowly", "loyal", "lucky", "luminous", "lush", "luxurious"
        };
     }
        
}
