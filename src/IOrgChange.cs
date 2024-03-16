public interface IOrgChange
{
   
    /*
        Preconditions:
            1.) addTo will be the company reference being altered.
    */
    public abstract void Apply(Company addTo);

};