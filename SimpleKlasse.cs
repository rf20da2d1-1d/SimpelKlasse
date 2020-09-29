using System;

namespace SimpleKlasse
{
    public class BraetSpil{
        // attributter
        private double _pris;
        private String _navn;
        private int _anbefaletAlder;
        private int _antalSpillere;
        private int _spilletid;


        // properties
        public double Pris{
            get{ return _pris;}
            set{ _pris = value;}
        }
        public String Navn{
            get{ return _navn;}
            set{ _navn = value;}
        }
        public int AnbefaletAlder{
            get{ return _anbefaletAlder;}
            set{ _anbefaletAlder = value;}
        }
        public int AntalSpillere{
            get{ return _antalSpillere;}
            set{ _antalSpillere = value;}
        }
        public int Spilletid{
            get{ return _spilletid;}
            set{ _spilletid = value;}
        }


        // konstruktør (navn altid det samme som klassen)

        // default værdier
        public BraetSpil(){
            _pris = 0;
            _navn = "";
            _anbefaletAlder = 0;
            _antalSpillere = 0;
            _spilletid = 0;

        }

        // eksplicitte værdier
        public BraetSpil(double pris, String navn, int alder, int spillere, int tid){
            _pris = pris;
            _navn = navn;
            _anbefaletAlder = alder;
            _antalSpillere = spillere;
            _spilletid = tid;

        }


        // metoder

        // udskriv information
        public String HentInfo(){
            return $"BrætSpil {_navn} anbefalet alder {_anbefaletAlder} for {_antalSpillere} spillere, det tager {_spilletid} min. og det koster {_pris}";
        }

    }


}
