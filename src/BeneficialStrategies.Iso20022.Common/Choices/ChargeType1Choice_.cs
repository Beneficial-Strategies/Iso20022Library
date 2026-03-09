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
    /// Amount of money associated with a type of service.
    /// </summary>
    [KnownType(typeof(ChargeType1Choice.Type))]
    [KnownType(typeof(ChargeType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeType1Choice.Type),nameof(ChargeType1Choice.Type))]
    [JsonDerivedType(typeof(ChargeType1Choice.Proprietary),nameof(ChargeType1Choice.Proprietary))]
    #endif
    [IsoId("_RhV09tp-Ed-ak6NoX_4Aeg_729960266")]
    [DisplayName("Charge Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType1Choice_
    #else
    public abstract partial class ChargeType1Choice_
    #endif
    {
    }
}
