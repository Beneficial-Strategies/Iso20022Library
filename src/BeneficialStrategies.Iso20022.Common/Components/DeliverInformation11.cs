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
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[IsoId("_ytfLYRgmEeK-_89we2b-bA")]
[DisplayName("Deliver Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliverInformation11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_eYB_NRgvEeK-_89we2b-bA")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_zCfyIRgmEeK-_89we2b-bA")]
    [DisplayName("Effective Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvSttlmDt")]
    #endif
    [IsoXmlTag("FctvSttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_zCfyJRgmEeK-_89we2b-bA")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [IsoId("_zCfyKRgmEeK-_89we2b-bA")]
    [DisplayName("Stamp Duty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmpDty")]
    #endif
    [IsoXmlTag("StmpDty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StampDutyType2Code? StampDuty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StampDutyType2Code? StampDuty { get; init; } 
    #else
    public StampDutyType2Code? StampDuty { get; set; } 
    #endif
    
    /// <summary>
    /// Deal amount.
    /// </summary>
    [IsoId("_zCfyLRgmEeK-_89we2b-bA")]
    [DisplayName("Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmt")]
    #endif
    [IsoXmlTag("NetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NetAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_zCfyMRgmEeK-_89we2b-bA")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge20? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge20? ChargeDetails { get; init; } 
    #else
    public Charge20? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_zCfyNRgmEeK-_89we2b-bA")]
    [DisplayName("Commission Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnDtls")]
    #endif
    [IsoXmlTag("ComssnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission12? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission12? CommissionDetails { get; init; } 
    #else
    public Commission12? CommissionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_zCfyORgmEeK-_89we2b-bA")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax15? TaxDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax15? TaxDetails { get; init; } 
    #else
    public Tax15? TaxDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_zCfyPRgmEeK-_89we2b-bA")]
    [DisplayName("Settlement Parties Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveringPartiesAndAccount8? SettlementPartiesDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveringPartiesAndAccount8? SettlementPartiesDetails { get; init; } 
    #else
    public DeliveringPartiesAndAccount8? SettlementPartiesDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_zCfyQRgmEeK-_89we2b-bA")]
    [DisplayName("Physical Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysTrf")]
    #endif
    [IsoXmlTag("PhysTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    #else
    public PhysicalTransferType1Code? PhysicalTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_zCfyRRgmEeK-_89we2b-bA")]
    [DisplayName("Physical Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysTrfDtls")]
    #endif
    [IsoXmlTag("PhysTrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    #else
    public DeliveryParameters4? PhysicalTransferDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
