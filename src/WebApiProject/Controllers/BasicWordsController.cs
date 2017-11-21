using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class BasicWordsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "I","i", "you", "they", "he", "she", "the", "a", "ty", "mommy", "all", "right", "i'm", "up", "oh", "slow", "down", "give", "here", "are", "we", "get", "to", "if", "you're", "tall", "yes", "not", "thing", "it", "just", "away", "your", "brother", "won't", "come", "on", "dead", "we're", "soon", "want", "now", "family", "time", "fresh", "air", "mom", "game", "it's", "my", "well", "our", "at", "be", "only", "die", "from", "is", "any", "sign", "of", "and", "an", "systems", "hey", "stop", "don't", "dr", "look", "he's", "with", "less", "will", "lose", "that's", "always", "for", "have", "that", "many", "other", "where", "no", "wanted", "didn't", "even", "who", "made", "me", "why", "they're", "everyone", "else", "better", "than", "what", "was", "cut", "ahead", "two", "sit", "kids", "in", "has", "power", "so", "can't", "there", "million", "third", "has an", "take", "us", "can", "go", "okay", "aah", "this", "too", "low", "must", "wow", "find", "know", "how", "then", "let's", "out", "help", "may", "think", "got", "over", "them", "more", "yeah", "sir", "see", "charts", "do", "animals", "threw", "when", "am", "children", "nor", "there's", "like", "maybe", "period", "soft", "hello", "door", "open", "eat", "place", "told", "safe", "by", "hold", "voice", "wrong", "would", "food", "please", "put", "were", "few", "back", "called", "hole", "captain", "their", "report", "nine", "one", "or", "sleep", "man", "once", "big", "tree", "father", "good", "i'll", "need", "thank", "send", "mama", "want to", "listen", "people", "say", "things", "uhhuh", "love", "his", "body", "degrees", "above", "normal", "rate", "per", "minute", "blood", "three", "doctor", "cannot", "try", "again", "leave", "but", "you'd", "very", "boys", "simply", "color", "access", "four", "five", "six", "seven", "eight", "ten", "milion", "handred", "hundred", "thousand", "thousands", "sky", "enough", "play", "him", "parents", "uh", "job", "turn", "off", "hope", "full", "tell", "human", "close", "what's", "going", "older", "kid", "god", "mind", "wish", "god's", "did", "single", "mother", "never", "found", "ah", "said", "couldn't", "way", "stand", "little", "should", "life", "as", "study", "sound", "doesn't", "best", "make", "trouble", "break", "free", "main", "years", "fly", "something", "set", "fast", "some", "had", "could", "wait", "panting", "birds", "most", "use", "basic", "small", "move", "alone", "you'll", "dark", "fine", "who's", "danger", "road", "new", "how's", "far", "bridge", "still", "days", "star", "lost", "anyway", "room", "able", "search", "signal", "class", "require", "rest", "because", "opens", "dislike", "her", "true", "hand", "haven't", "name", "lucky", "others", "sons", "young", "long", "water", "millions", "killed", "idea", "pants", "chance", "large", "last", "fire", "nice", "used", "lie", "hate", "story", "mom's", "names", "lived", "'said", "old", "'you", "into", "'or", "'but", "'your", "'he", "pie", "run", "along", "resume", "journey", "bed", "none", "kill", "gone", "hear", "scans", "baby", "heard", "sorry", "ma'am", "space", "order", "though", "wide", "done", "team", "such", "everything", "also", "font", "media", "group" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
