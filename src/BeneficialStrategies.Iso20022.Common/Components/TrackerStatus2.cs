// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction status to be updated in the tracker.
/// </summary>
[IsoId("_miaboc79EemEIuVuDudp4g")]
[DisplayName("Tracker Status")]
public partial record TrackerStatus2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_mtb_4879EemEIuVuDudp4g")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ExternalPaymentTransactionStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Date for the status.
    /// </summary>
    [IsoId("_QuXA8c_jEemHcp9lKLekIw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice_? Date { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_mtb_5c79EemEIuVuDudp4g")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public TrackerAlertStatusReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_mtb_5879EemEIuVuDudp4g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
