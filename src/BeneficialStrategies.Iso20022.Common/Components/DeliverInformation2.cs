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
[IsoId("_VMxk59p-Ed-ak6NoX_4Aeg_-1013586045")]
[DisplayName("Deliver Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeliverInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeliverInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeliverInformation2( DeliveringPartiesAndAccount1 reqSettlementPartiesDetails,System.String reqPhysicalTransferIndicator )
    {
        SettlementPartiesDetails = reqSettlementPartiesDetails;
        PhysicalTransferIndicator = reqPhysicalTransferIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_VMxk6Np-Ed-ak6NoX_4Aeg_-214525296")]
    [DisplayName("Charge Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgDtls")]
    #endif
    [IsoXmlTag("ChrgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge4? ChargeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge4? ChargeDetails { get; init; } 
    #else
    public Charge4? ChargeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_VMxk6dp-Ed-ak6NoX_4Aeg_534530656")]
    [DisplayName("Tax Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxDtls")]
    #endif
    [IsoXmlTag("TaxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax3? TaxDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax3? TaxDetails { get; init; } 
    #else
    public Tax3? TaxDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_VMxk6tp-Ed-ak6NoX_4Aeg_-889025934")]
    [DisplayName("Settlement Parties Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliveringPartiesAndAccount1 SettlementPartiesDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliveringPartiesAndAccount1 SettlementPartiesDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveringPartiesAndAccount1 SettlementPartiesDetails { get; init; } 
    #else
    public DeliveringPartiesAndAccount1 SettlementPartiesDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VMxk69p-Ed-ak6NoX_4Aeg_-1109217545")]
    [DisplayName("Physical Transfer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysTrfInd")]
    #endif
    [IsoXmlTag("PhysTrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PhysicalTransferIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhysicalTransferIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhysicalTransferIndicator { get; init; } 
    #else
    public System.String PhysicalTransferIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    [IsoId("_VM7V4Np-Ed-ak6NoX_4Aeg_-816993140")]
    [DisplayName("Physical Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysTrfDtls")]
    #endif
    [IsoXmlTag("PhysTrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryParameters2? PhysicalTransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryParameters2? PhysicalTransferDetails { get; init; } 
    #else
    public DeliveryParameters2? PhysicalTransferDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
