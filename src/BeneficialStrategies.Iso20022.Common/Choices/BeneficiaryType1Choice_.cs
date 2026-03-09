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
    /// Choice of formats for a type of beneficiary.
    /// </summary>
    [KnownType(typeof(BeneficiaryType1Choice.Code))]
    [KnownType(typeof(BeneficiaryType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BeneficiaryType1Choice.Code),nameof(BeneficiaryType1Choice.Code))]
    [JsonDerivedType(typeof(BeneficiaryType1Choice.Proprietary),nameof(BeneficiaryType1Choice.Proprietary))]
    #endif
    [IsoId("_xDPgIFNgEeijdq8ilaxyOA")]
    [DisplayName("Beneficiary Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BeneficiaryType1Choice_
    #else
    public abstract partial class BeneficiaryType1Choice_
    #endif
    {
    }
}
