﻿using ConferenceDTO;
using System.Collections.Generic;

namespace BackEnd.Data
{
    public class Conference : ConferenceDTO.Conference
    {
        public virtual ICollection<Track> Tracks { get; set; }

        public virtual ICollection<Speaker> Speakers { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<ConferenceAttendee> ConferenceAttendees { get; set; }
    }
}