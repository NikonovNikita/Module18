﻿namespace Module18.Builder;

internal class Product
{
    List<object> parts = new List<object>();

    public void Add(string part)
    {
        parts.Add(part);
    }
}
