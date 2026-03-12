// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the commodity quantity in tons or the amount and currency used (for example carbone dioxide).
    /// </summary>
    [KnownType(typeof(TonsOrCurrency2Choice.Number))]
    [KnownType(typeof(TonsOrCurrency2Choice.Amount))]
    [JsonDerivedType(typeof(TonsOrCurrency2Choice.Number),nameof(TonsOrCurrency2Choice.Number))]
    [JsonDerivedType(typeof(TonsOrCurrency2Choice.Amount),nameof(TonsOrCurrency2Choice.Amount))]
    [IsoId("_Z5jxEWlSEeaLAKoEUNsD9g")]
    [DisplayName("Tons Or Currency 2 Choice")]
    public abstract partial record TonsOrCurrency2Choice_
    {
    }
}
