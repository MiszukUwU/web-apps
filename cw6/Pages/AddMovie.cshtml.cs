﻿using cw6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw6.Pages;

public class AddMovie : PageModel {
    [BindProperty]
    public Movie? MyMovie { get; set; }
    public void OnGet(){
        
    }
}