/*
    Invariants:
        1.) this.nameTeam is the name of the team to move a hired Employee named this.nameEmployee to.
        2.) this.nameTeam and this.nameEmployee will be constant throughout instance lifetime.
        3.) this.nameEmployee is non-empty.
        4.) A null this.nameTeam means add to no team the hired Employee, this.nameEmployee.
*/
public class TransferOperation : IOrgChange
{

    // Able to see names of what to add, but cannot change their state
    public readonly string nameEmployee;
    public readonly string? nameTeam;

    public TransferOperation(string newEmployee, string? newTeam)
    {

        this.nameEmployee = newEmployee;
        this.nameTeam = newTeam;

    }

    /*
       Preconditions:
           1.) this.nameEmployee exists as a hired Employee name in addTo.
           2.) this.nameTeam exists in addTo when not null.
       Postconditions:
           1.) Removes this.nameEmployee in addTo from its previous team.
           2.) Adds hired Employee this.nameEmployee in addTo to team, this.nameTeam.
   */
    public void Apply(Company addTo)
    {

        // Holding scope of ref. of our class so when removed, can read.
        Employee employeeHandler = addTo.getEmployee(this.nameEmployee);
        addTo.dissolveEmployee(employeeHandler);

        if (nameTeam != null)
        {

            addTo.getTeam(this.nameTeam).addEmployee(employeeHandler);

        }

    }

};