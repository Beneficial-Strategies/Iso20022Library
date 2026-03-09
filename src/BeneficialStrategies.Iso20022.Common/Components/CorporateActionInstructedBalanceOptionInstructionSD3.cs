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
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_aq9fEegXEei5aPS232E3Mw")]
[DisplayName("Corporate Action Instructed Balance Option Instruction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionInstructedBalanceOptionInstructionSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionInstructedBalanceOptionInstructionSD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionInstructedBalanceOptionInstructionSD3( OptionNumber1Choice_ reqOptionNumber,DTCInstructionStatus2Code reqTransactionIdentificationStatus )
    {
        OptionNumber = reqOptionNumber;
        TransactionIdentificationStatus = reqTransactionIdentificationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_bOg4EegXEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_bOg4E-gXEei5aPS232E3Mw")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_bOg4IegXEei5aPS232E3Mw")]
    [DisplayName("Transaction Contra CUSIP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxContraCUSIP")]
    #endif
    [IsoXmlTag("TxContraCUSIP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    #else
    public OtherIdentification2? TransactionContraCUSIP { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_bOg4JegXEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdOvrsbcptQty")]
    #endif
    [IsoXmlTag("TxIdOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_bOg4J-gXEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdSts")]
    #endif
    [IsoXmlTag("TxIdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    #else
    public DTCInstructionStatus2Code TransactionIdentificationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
