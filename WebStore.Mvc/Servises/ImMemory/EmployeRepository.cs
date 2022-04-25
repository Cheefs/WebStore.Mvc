using WebStore.Mvc.Models;
using WebStore.Mvc.Servises.Interfaces;

namespace WebStore.Mvc.Servises.InMemory;

public class EmployeRepository : IRepository<EmployeViewModel>
{
    private readonly List<EmployeViewModel> _employes;

    public EmployeRepository()
    {
        _employes = new List<EmployeViewModel>
        {
            new EmployeViewModel
            {
                Id = 1,
                FirstName = "FirstName 1",
                LastName = "LastName 1",
                Patronymic = "Patronymic 1",
                Age = 25
            },
            new EmployeViewModel
            {
                Id = 2,
                FirstName = "FirstName 2",
                LastName = "LastName 2",
                Patronymic = "Patronymic 2",
                Age = 34
            },
            new EmployeViewModel
            {
                Id = 31,
                FirstName = "FirstName 31",
                LastName = "LastName 31",
                Patronymic = "Patronymic 31",
                Age = 43
            }
        };
    }

    public IEnumerable<EmployeViewModel> GetAll()
    {
        return _employes;
    }

    public EmployeViewModel? GetById(int? id)
    {
        return _employes.Find(el => el.Id == id);
    }

    public bool Delete(int id)
    {
        var employe = GetById(id);
        return employe != null && _employes.Remove(employe);
    }

    public bool Update(EmployeViewModel data)
    {
        var index = _employes.FindIndex(el => el.Id == data.Id);
        _employes[index] = data;

        return true;
    }

    public int Add(EmployeViewModel data)
    {
        var index = _employes.Last().Id + 1;
        _employes.Add(new EmployeViewModel
        {
            Id = index,
            FirstName = data.FirstName,
            LastName = data.LastName,
            Age = data.Age,
            Patronymic = data.Patronymic
        });

        return index ?? 1;
    }
}
