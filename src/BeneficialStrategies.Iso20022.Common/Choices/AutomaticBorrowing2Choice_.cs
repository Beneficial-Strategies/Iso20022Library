// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing2Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing2Choice.Proprietary))]
    [JsonDerivedType(typeof(AutomaticBorrowing2Choice.Code),nameof(AutomaticBorrowing2Choice.Code))]
    [JsonDerivedType(typeof(AutomaticBorrowing2Choice.Proprietary),nameof(AutomaticBorrowing2Choice.Proprietary))]
    [IsoId("_QtyRFNp-Ed-ak6NoX_4Aeg_-1043359290")]
    [DisplayName("Automatic Borrowing 2 Choice")]
    public abstract partial record AutomaticBorrowing2Choice_
    {
    }
}
