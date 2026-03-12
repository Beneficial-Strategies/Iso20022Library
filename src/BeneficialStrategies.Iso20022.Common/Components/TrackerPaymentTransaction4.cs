// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key elements used to identify the original transaction(s) that is being referred to.
/// </summary>
[IsoId("_k0GOXfY0Eemf4dJxCjghNw")]
[DisplayName("Tracker Payment Transaction")]
public partial record TrackerPaymentTransaction4
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_k0GOX_Y0Eemf4dJxCjghNw")]
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; init; } 
    
    /// <summary>
    /// Party that provides information on the alert status and related details.
    /// </summary>
    [IsoId("_k0GOYfY0Eemf4dJxCjghNw")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification1? TrackerInformingParty { get; init; } 
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_k0GOZfY0Eemf4dJxCjghNw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification11 PaymentIdentification { get; init; } 
    
    /// <summary>
    /// Agreement under which or rules under which the payment transaction should be processed.
    /// </summary>
    [IsoId("_k0GOZ_Y0Eemf4dJxCjghNw")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public TransactionServiceLevel1? ServiceLevel { get; init; } 
    
    
    #nullable disable
    
}
