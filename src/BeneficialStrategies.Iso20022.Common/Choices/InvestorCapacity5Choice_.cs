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
    /// Choice of format for the investor capacity.
    /// </summary>
    [KnownType(typeof(InvestorCapacity5Choice.Code))]
    [KnownType(typeof(InvestorCapacity5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestorCapacity5Choice.Code),nameof(InvestorCapacity5Choice.Code))]
    [JsonDerivedType(typeof(InvestorCapacity5Choice.Proprietary),nameof(InvestorCapacity5Choice.Proprietary))]
    #endif
    [IsoId("_5mtMY5NLEeWGlc8L7oPDIg")]
    [DisplayName("Investor Capacity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestorCapacity5Choice_
    #else
    public abstract partial class InvestorCapacity5Choice_
    #endif
    {
    }
}
