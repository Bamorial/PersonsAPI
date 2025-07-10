using System;
using System.Collections.Generic;
using System.Linq;

public static class PaginationExtensions
{
    public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int itemsPerPage, int pageIndex)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        if (pageIndex < 0)
            throw new ArgumentOutOfRangeException(nameof(pageIndex), "Page index must be 0 or greater.");
        if (itemsPerPage <= 0)
            throw new ArgumentOutOfRangeException(nameof(itemsPerPage), "Items per page must be greater than 0.");

        return source.Skip(pageIndex * itemsPerPage).Take(itemsPerPage);
    }
}
