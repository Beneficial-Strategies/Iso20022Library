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
    /// Specifies the type of repurchase agreement.
    /// </summary>
    [KnownType(typeof(RepurchaseAgreementType3Choice.SpecificCollateral))]
    [KnownType(typeof(RepurchaseAgreementType3Choice.GeneralCollateral))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RepurchaseAgreementType3Choice.SpecificCollateral),nameof(RepurchaseAgreementType3Choice.SpecificCollateral))]
    [JsonDerivedType(typeof(RepurchaseAgreementType3Choice.GeneralCollateral),nameof(RepurchaseAgreementType3Choice.GeneralCollateral))]
    #endif
    [IsoId("_BgUqseoaEeadseq5W5YLvQ")]
    [DisplayName("Repurchase Agreement Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepurchaseAgreementType3Choice_
    #else
    public abstract partial class RepurchaseAgreementType3Choice_
    #endif
    {
    }
}
