﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdz_8_zad_2
{
    public enum SortCriteria
    {
        SizeThenKind,
        KindThenSize
    }
    class DuckComparer : IComparer<Duck>
    {
        //przypisanie do pola, typu wartościowego
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                {
                    return 1;
                }
                else if (x.Size < y.Size)
                {
                    return -1;
                }
                else
                {
                    if (x.Kind > y.Kind)
                    {
                        return 1;
                    }
                    else if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else
                        return 0;
                }
            }
            else
            {
                if (x.Kind > y.Kind)
                {
                    return 1;
                }
                else if (x.Kind < y.Kind)
                {
                    return -1;
                }
                else
                {
                    if (x.Size > y.Size)
                    {
                        return 1;
                    }
                    else if (x.Size < y.Size)
                    {
                        return -1;
                    }
                    else
                        return 0;
                }
            }
        }
    }
}