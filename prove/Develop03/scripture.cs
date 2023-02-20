using System;
using System.Collections.Generic;
using System.Linq;
class Scripture
{
    public Reference Reference{ get; set; }
    public List<Word> Words{ get; set; }

    public Scripture(Reference reference, List<Word> words)
    {
        Reference = reference;
        Words = words;
    }
}