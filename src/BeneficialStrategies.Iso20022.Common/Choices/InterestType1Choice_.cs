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
    /// Interest type is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(InterestType1Choice.Code))]
    [KnownType(typeof(InterestType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestType1Choice.Code),nameof(InterestType1Choice.Code))]
    [JsonDerivedType(typeof(InterestType1Choice.Proprietary),nameof(InterestType1Choice.Proprietary))]
    #endif
    [IsoId("_SRnbVtp-Ed-ak6NoX_4Aeg_-822918144")]
    [DisplayName("Interest Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestType1Choice_
    #else
    public abstract partial class InterestType1Choice_
    #endif
    {
    }
}
