using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class GameModel
    {
        [Display(Name ="Enter Your Name")]
        public string PlayerName { get; set; }

        [Display(Name = "What is Your Guess?")]
        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }
}