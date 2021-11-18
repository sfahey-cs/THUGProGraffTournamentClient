using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace THUGProGraffTournamentClient
{
    [FirestoreData]
    public class Player
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public bool Active { get; set; }
        [FirestoreProperty]
        public int MaxTags { get; set; }
    }
}
