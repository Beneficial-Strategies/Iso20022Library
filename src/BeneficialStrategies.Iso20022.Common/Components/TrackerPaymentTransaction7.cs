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
[IsoId("_n7bpJ2RPEeqImsG9JNoSQw")]
[DisplayName("Tracker Payment Transaction")]
public partial record TrackerPaymentTransaction7
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_oC8mYWRPEeqImsG9JNoSQw")]
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 
    
    /// <summary>
    /// Party that provides information on the alert status and related details.
    /// </summary>
    [IsoId("_oC8mY2RPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    
    /// <summary>
    /// Party that is updated on the alert status and related details.
    /// </summary>
    [IsoId("_oC8mZWRPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informed Party")]
    [IsoXmlTag("TrckrInfrmdPty")]
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_oC8mZ2RPEeqImsG9JNoSQw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public PaymentIdentification10? PaymentIdentification { get; init; } 
    
    /// <summary>
    /// Agreement under which or rules under which the payment transaction should be processed.
    /// </summary>
    [IsoId("_oC8maWRPEeqImsG9JNoSQw")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    
    
    #nullable disable
    
}
