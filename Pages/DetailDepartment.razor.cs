
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using PAS.Models;
using PAS.Services;

namespace PAS.Pages
{
    public partial class DetailDepartment
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public Department Department { get; set; } //= new Department();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Department = await DepartmentService.GetById(int.Parse(id));
        }
    }
}