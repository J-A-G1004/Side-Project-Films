using System;
using System.Collections.Generic;
using System.Text;

namespace Film_Recomend
{
    class Film
    {
        public string FilmName { get; private set; }
        public int ID { get; private set; }
        public string Description { get; private set; }
        public string Rating;


        public Film () //add consrtuctors later as the addfilm add id add descryption add rating methods will need to be added first 
        {

        }
    }
}
