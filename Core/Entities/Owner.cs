﻿namespace Core.Entities
{
  public  class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Profile { get; set; }
        Address Address { get; set; }
    }
}
