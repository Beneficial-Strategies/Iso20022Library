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
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_VOajpdp-Ed-ak6NoX_4Aeg_-1021622577")]
[DisplayName("Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transfer3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transfer3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transfer3( System.String reqTransferReference,FinancialInstrumentQuantity1 reqTotalUnitsNumber,System.String reqOwnAccountTransferIndicator )
    {
        TransferReference = reqTransferReference;
        TotalUnitsNumber = reqTotalUnitsNumber;
        OwnAccountTransferIndicator = reqOwnAccountTransferIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VOajptp-Ed-ak6NoX_4Aeg_172416714")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_VOajp9p-Ed-ak6NoX_4Aeg_236844217")]
    [DisplayName("Transfer Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfDt")]
    #endif
    [IsoXmlTag("TrfDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat1Choice_? TransferDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat1Choice_? TransferDate { get; init; } 
    #else
    public DateFormat1Choice_? TransferDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_VOajqNp-Ed-ak6NoX_4Aeg_826469126")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1 TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [IsoId("_VOajqdp-Ed-ak6NoX_4Aeg_-443498289")]
    [DisplayName("Own Account Transfer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnAcctTrfInd")]
    #endif
    [IsoXmlTag("OwnAcctTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator OwnAccountTransferIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OwnAccountTransferIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OwnAccountTransferIndicator { get; init; } 
    #else
    public System.String OwnAccountTransferIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
