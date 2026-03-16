// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction Status1.
/// </summary>
[IsoId("_lbVzYfSTEe2NguPP5QspEw")]
[DisplayName("Payment Transaction Status1")]
public partial record PaymentTransactionStatus1
{
    #nullable enable

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransactionStatus1Choice_ Status { get; init; } 

    /// <summary>
    /// Status Reason Information.
    /// </summary>
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    
    #nullable disable
    
}
