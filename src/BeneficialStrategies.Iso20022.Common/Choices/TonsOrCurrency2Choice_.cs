// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the commodity quantity in tons or the amount and currency used (for example carbone dioxide).
    /// </summary>
    [KnownType(typeof(TonsOrCurrency2Choice.Number))]
    [KnownType(typeof(TonsOrCurrency2Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TonsOrCurrency2Choice.Number),nameof(TonsOrCurrency2Choice.Number))]
    [JsonDerivedType(typeof(TonsOrCurrency2Choice.Amount),nameof(TonsOrCurrency2Choice.Amount))]
    #endif
    [IsoId("_Z5jxEWlSEeaLAKoEUNsD9g")]
    [DisplayName("Tons Or Currency 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TonsOrCurrency2Choice_
    #else
    public abstract partial class TonsOrCurrency2Choice_
    #endif
    {
    }
}
