using System;

public class ZipCode
{
    private readonly string value;
    public ZipCode(string value)
    {
        this.value = value;
    }
    public string Value
    {
        get { return this.value; }   
    }
}

public class Address
{
    public string ZipCode { get; set; }

    void ValidateZipCode(string zipCode)
    {

    }
}

