// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the future status of the transaction by means of a code
/// </summary>
[IsoId("_w_JcYMX1EeiSF9q-coWegA")]
[DisplayName("Transaction Status")]
public partial record TransactionStatus6
{
    #nullable enable
    
    /// <summary>
    /// Provides the status after comparing the exposure and the collateral required for the transaction.
    /// </summary>
    [IsoId("_JCKzsMX6EeiSF9q-coWegA")]
    [DisplayName("Coverage Status")]
    [IsoXmlTag("CvrgSts")]
    public CollateralStatus1Code? CoverageStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the transaction is pending initiation or has been initiated.
    /// </summary>
    [IsoId("_P4TlEMX6EeiSF9q-coWegA")]
    [DisplayName("Execution Status")]
    [IsoXmlTag("ExctnSts")]
    public CollateralStatus2Choice_? ExecutionStatus { get; init; } 
    
    
    #nullable disable
    
}
