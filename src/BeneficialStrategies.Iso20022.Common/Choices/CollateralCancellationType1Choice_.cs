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
    /// Choice between a code and a proprietary code for the reason the collateral message has been cancelled.
    /// </summary>
    [KnownType(typeof(CollateralCancellationType1Choice.Code))]
    [KnownType(typeof(CollateralCancellationType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralCancellationType1Choice.Code),nameof(CollateralCancellationType1Choice.Code))]
    [JsonDerivedType(typeof(CollateralCancellationType1Choice.Proprietary),nameof(CollateralCancellationType1Choice.Proprietary))]
    #endif
    [IsoId("_QmogONp-Ed-ak6NoX_4Aeg_-847110751")]
    [DisplayName("Collateral Cancellation Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralCancellationType1Choice_
    #else
    public abstract partial class CollateralCancellationType1Choice_
    #endif
    {
    }
}
