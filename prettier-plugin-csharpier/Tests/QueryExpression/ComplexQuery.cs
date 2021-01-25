class ClassName
{
    void MethodName()
    {
        var query = from c in customers
            let d = c
            where d != null
            join c1 in customers on c1.GetHashCode() equals c.GetHashCode()
            join c1 in customers on c1.GetHashCode() equals c.GetHashCode() into e
            group c by c.Country into g
            orderby g.Count() ascending
            orderby g.Key descending
            select new { Country = g.Key, CustCount = g.Count() };
    }
}
