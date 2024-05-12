//Strings

string alice = @"Alice was beginning to get very tired of sitting by her sister on the
bank, and of having nothing to do: once or twice she had peeped into the
book her sister was reading, but it had no pictures or conversations in
it, 'and what is the use of a book,' thought Alice 'without pictures or
conversation?'";

Console.WriteLine("Please enter the word to search?");
string search = Console.ReadLine();
string lowerSearch = search.ToLower();
string lowerAlice = alice.ToLower();

int location = lowerAlice.IndexOf(lowerSearch);
int searchLength = lowerSearch.Length;



if (lowerAlice.IndexOf(lowerSearch, 0)
!= -1) {
    Console.WriteLine("true");
    Console.WriteLine ("The index of word you are looking for is: " + location);
    Console.WriteLine ("The length of the word you are searching is: " + searchLength);
    if(lowerAlice.Contains(lowerAlice)) {
        string newAlice = alice.Remove(location, searchLength + 1);
        Console.WriteLine(newAlice);
        };
} else {
    Console.WriteLine("false");
};
