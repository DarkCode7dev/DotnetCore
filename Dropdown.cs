   public ActionResult EmployeeInfo()
        {
             ViewBag.Countries = new SelectList(GetCountries(), "ID", "Name");
           // TempData["Countries"] = GetCountries();
            return View();
        }
        
        
        
        public List<Country> GetCountries()
        {
            IEnumerable<Country> data = IOperations.DataFetchDropdown("COUNTRY");
            IEnumerable<Country> data1 =  data;

            List<Country> listofcountry= data1.ToList();

            return listofcountry;



        }
        
        
        ==============cshtml
         <select asp-for="ID" asp-items="ViewBag.Countries">
                        <option>Choose the Category</option>
                        <option></option>
                    </select>
