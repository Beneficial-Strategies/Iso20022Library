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
    /// Specifies the choice between the major categories of repurchase agreement.
    /// </summary>
    [KnownType(typeof(RepurchaseAgreementType1Choice.SpecificCollateral))]
    [KnownType(typeof(RepurchaseAgreementType1Choice.GeneralCollateral))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepurchaseAgreementType1Choice.SpecificCollateral),nameof(RepurchaseAgreementType1Choice.SpecificCollateral))]
    [JsonDerivedType(typeof(RepurchaseAgreementType1Choice.GeneralCollateral),nameof(RepurchaseAgreementType1Choice.GeneralCollateral))]
    #endif
    [IsoId("_3-Tf4LbqEeaqL_M7XFD7PQ")]
    [DisplayName("Repurchase Agreement Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseAgreementType1Choice_
    #else
    public abstract partial class RepurchaseAgreementType1Choice_
    #endif
    {
    }
}
