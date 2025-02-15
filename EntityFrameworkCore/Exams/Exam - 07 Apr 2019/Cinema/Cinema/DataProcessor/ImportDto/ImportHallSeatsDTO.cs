﻿    
using System.ComponentModel.DataAnnotations;

namespace Cinema.DataProcessor.ImportDto
{
    public class ImportHallSeatsDTO
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        public bool Is4Dx { get; set; }

        public bool Is3D { get; set; }

        [Range(1, int.MaxValue)]
        public int Seats { get; set; }
    }
}

//{
//    "Name": "Methocarbamol",
//    "Is4Dx": false,
//    "Is3D": true,
//    "Seats": 52
//  },

