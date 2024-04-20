

using Flunt.Validations;
using System.Diagnostics.Contracts;

namespace IWantApp.Domain.Products;

public  class Category : Entity
{
    
    public bool Active { get; set; } 

    public Category(string name, string createBY, string editeBy)
    {
        var contract = new Contract<Category>()
        .IsNotNullOrEmpty(name, "Name")
        .IsNotNullOrEmpty(createBY, "CreateBY")
        .IsNotNullOrEmpty(editeBy, "EditeBy");


        AddNotifications(contract);

        Name = name;
        Active = true; 
        CreateBY = createBY; // ortografia errada , mas a Migration foi criada assim.
        EditeBy = editeBy;
        CreateOn = DateTime.Now;
        EditeOn = DateTime.Now;
    }


}
