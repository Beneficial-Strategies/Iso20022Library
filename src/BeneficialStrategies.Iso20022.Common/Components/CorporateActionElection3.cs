// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about a corporate action election.
/// </summary>
[IsoId("_UJ39d9p-Ed-ak6NoX_4Aeg_-1634086378")]
[DisplayName("Corporate Action Election")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionElection3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the account.
    /// </summary>
    [IsoId("_UJ39eNp-Ed-ak6NoX_4Aeg_-1717682218")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount7? AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount7? AccountDetails { get; init; } 
    #else
    public SecuritiesAccount7? AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UKBHYNp-Ed-ak6NoX_4Aeg_-1215732423")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_? OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UKBHYdp-Ed-ak6NoX_4Aeg_-1591604434")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of underlying securities to which this instruction applies.
    /// </summary>
    [IsoId("_UKBHYtp-Ed-ak6NoX_4Aeg_-758588422")]
    [DisplayName("Instructed Underlying Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdUndrlygSctiesQty")]
    #endif
    [IsoXmlTag("InstdUndrlygSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? InstructedUnderlyingSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? InstructedUnderlyingSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? InstructedUnderlyingSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the benefits that the account owner wants to receive, eg, as a result of dividend reinvestment.
    /// </summary>
    [IsoId("_UKBHY9p-Ed-ak6NoX_4Aeg_1915148636")]
    [DisplayName("Instructed Securities Quantity To Receive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdSctiesQtyToRcv")]
    #endif
    [IsoXmlTag("InstdSctiesQtyToRcv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? InstructedSecuritiesQuantityToReceive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? InstructedSecuritiesQuantityToReceive { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? InstructedSecuritiesQuantityToReceive { get; set; } 
    #endif
    
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_UKBHZNp-Ed-ak6NoX_4Aeg_101209579")]
    [DisplayName("Proposed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdRate")]
    #endif
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ProposedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ProposedRate { get; init; } 
    #else
    public System.Decimal? ProposedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash movement resulting from the election instruction.
    /// </summary>
    [IsoId("_UKBHZdp-Ed-ak6NoX_4Aeg_-1328972579")]
    [DisplayName("Cash Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmntDtls")]
    #endif
    [IsoXmlTag("CshMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCashMovements2? CashMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCashMovements2? CashMovementDetails { get; init; } 
    #else
    public CorporateActionCashMovements2? CashMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the securities movement resulting from the election instruction.
    /// </summary>
    [IsoId("_UKBHZtp-Ed-ak6NoX_4Aeg_-1078102161")]
    [DisplayName("Securities Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntDtls")]
    #endif
    [IsoXmlTag("SctiesMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionSecuritiesMovement2? SecuritiesMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionSecuritiesMovement2? SecuritiesMovementDetails { get; init; } 
    #else
    public CorporateActionSecuritiesMovement2? SecuritiesMovementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
