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
    /// Choice to provide the collateral balance for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(CollateralBalance1Choice.TotalCollateral))]
    [KnownType(typeof(CollateralBalance1Choice.CollateralDetails))]
    [KnownType(typeof(CollateralBalance1Choice.SegregatedIndependentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CollateralBalance1Choice.TotalCollateral),nameof(CollateralBalance1Choice.TotalCollateral))]
    [JsonDerivedType(typeof(CollateralBalance1Choice.CollateralDetails),nameof(CollateralBalance1Choice.CollateralDetails))]
    [JsonDerivedType(typeof(CollateralBalance1Choice.SegregatedIndependentAmount),nameof(CollateralBalance1Choice.SegregatedIndependentAmount))]
    #endif
    [IsoId("_UnXxx9p-Ed-ak6NoX_4Aeg_-92530976")]
    [DisplayName("Collateral Balance 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CollateralBalance1Choice_
    #else
    public abstract partial class CollateralBalance1Choice_
    #endif
    {
    }
}
