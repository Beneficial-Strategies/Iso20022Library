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
/// Instructions, initiated by the creditor, to debit a debtor&apos;s account in favour of the creditor.
/// </summary>
[IsoId("_H6sjw249EeiU9cctagi5ow")]
[DisplayName("Direct Debit Instruction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DirectDebitInstructionDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DirectDebitInstructionDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DirectDebitInstructionDetails2( System.String reqMandateIdentification,PartyIdentification135 reqCreditor )
    {
        MandateIdentification = reqMandateIdentification;
        Creditor = reqCreditor;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the mandate for a direct debit instruction.
    /// </summary>
    [IsoId("_IGnfsW49EeiU9cctagi5ow")]
    [DisplayName("Mandate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtId")]
    #endif
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MandateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MandateIdentification { get; init; } 
    #else
    public System.String MandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the instruction is an automated direct debit instruction.
    /// Usage: Default value for AutomatedDirectDebitInstructionIndicator is false.
    /// </summary>
    [IsoId("_IGnfs249EeiU9cctagi5ow")]
    [DisplayName("Automated Direct Debit Instruction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtdDrctDbtInstrInd")]
    #endif
    [IsoXmlTag("AutomtdDrctDbtInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AutomatedDirectDebitInstructionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AutomatedDirectDebitInstructionIndicator { get; init; } 
    #else
    public System.String? AutomatedDirectDebitInstructionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the direct debit instruction is transferable.
    /// Usage: Default value for DirectDebitTransferableIndicator is false.
    /// </summary>
    [IsoId("_IGnftW49EeiU9cctagi5ow")]
    [DisplayName("Direct Debit Transferable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtTrfblInd")]
    #endif
    [IsoXmlTag("DrctDbtTrfblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DirectDebitTransferableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DirectDebitTransferableIndicator { get; init; } 
    #else
    public System.String? DirectDebitTransferableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_IGnft249EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 Creditor { get; init; } 
    #else
    public PartyIdentification135 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the last debit made for the direct debit mandate.
    /// </summary>
    [IsoId("_IGnfuW49EeiU9cctagi5ow")]
    [DisplayName("Last Collection Currency Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastColltnCcyAmt")]
    #endif
    [IsoXmlTag("LastColltnCcyAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? LastCollectionCurrencyAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? LastCollectionCurrencyAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? LastCollectionCurrencyAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the last debit for the direct debit mandate may be made.
    /// Usage: Not included if all limits to the validity of the direct debit mandate have already been specified or if there are no time limits on the validity of the direct debit.
    /// </summary>
    [IsoId("_IGnfu249EeiU9cctagi5ow")]
    [DisplayName("Last Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastColltnDt")]
    #endif
    [IsoXmlTag("LastColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LastCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LastCollectionDate { get; init; } 
    #else
    public System.DateOnly? LastCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further information about the status of a requested transaction schedule transfer.
    /// </summary>
    [IsoId("_IGnfvW49EeiU9cctagi5ow")]
    [DisplayName("Other Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDtls")]
    #endif
    [IsoXmlTag("OthrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferInstruction1? OtherDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferInstruction1? OtherDetails { get; init; } 
    #else
    public TransferInstruction1? OtherDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
