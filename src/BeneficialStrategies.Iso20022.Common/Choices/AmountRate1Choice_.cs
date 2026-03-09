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
    /// Amount of money associated with a service.
    /// </summary>
    [KnownType(typeof(AmountRate1Choice.Amount))]
    [KnownType(typeof(AmountRate1Choice.Rate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountRate1Choice.Amount),nameof(AmountRate1Choice.Amount))]
    [JsonDerivedType(typeof(AmountRate1Choice.Rate),nameof(AmountRate1Choice.Rate))]
    #endif
    [IsoId("_RiFb0Np-Ed-ak6NoX_4Aeg_-1508717107")]
    [DisplayName("Amount Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountRate1Choice_
    #else
    public abstract partial class AmountRate1Choice_
    #endif
    {
    }
}
