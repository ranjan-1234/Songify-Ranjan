﻿namespace Singer.Models
{
    // For Register endpoint
    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
