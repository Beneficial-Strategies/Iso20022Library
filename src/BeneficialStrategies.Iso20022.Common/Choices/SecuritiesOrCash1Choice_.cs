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
    /// Choice of securities or cash parties.
    /// </summary>
    [KnownType(typeof(SecuritiesOrCash1Choice.SecuritiesDetails))]
    [KnownType(typeof(SecuritiesOrCash1Choice.CashPartiesDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesOrCash1Choice.SecuritiesDetails),nameof(SecuritiesOrCash1Choice.SecuritiesDetails))]
    [JsonDerivedType(typeof(SecuritiesOrCash1Choice.CashPartiesDetails),nameof(SecuritiesOrCash1Choice.CashPartiesDetails))]
    #endif
    [IsoId("_xeOrADcgEeOA3chqL9a4Rw")]
    [DisplayName("Securities Or Cash 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesOrCash1Choice_
    #else
    public abstract partial class SecuritiesOrCash1Choice_
    #endif
    {
    }
}
