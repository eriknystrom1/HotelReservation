﻿using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Services.ReservationConflictValidators
{
    public interface IReservationConflictValidator
    {

        // Reservation Task
        Task<Reservation> GetConflictingReservation(Reservation reservation);
    }
}
