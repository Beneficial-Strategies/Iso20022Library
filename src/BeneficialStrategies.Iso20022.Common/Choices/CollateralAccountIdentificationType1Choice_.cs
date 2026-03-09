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
    /// Specifies the identification of the collateral account.
    /// </summary>
    [KnownType(typeof(CollateralAccountIdentificationType1Choice.Type))]
    [KnownType(typeof(CollateralAccountIdentificationType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralAccountIdentificationType1Choice.Type),nameof(CollateralAccountIdentificationType1Choice.Type))]
    [JsonDerivedType(typeof(CollateralAccountIdentificationType1Choice.Proprietary),nameof(CollateralAccountIdentificationType1Choice.Proprietary))]
    #endif
    [IsoId("_vW0gN6MOEeCojJW5vEuTEQ_2023002417")]
    [DisplayName("Collateral Account Identification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralAccountIdentificationType1Choice_
    #else
    public abstract partial class CollateralAccountIdentificationType1Choice_
    #endif
    {
    }
}
