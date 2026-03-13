// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction and it&apos;s status to be updated in the tracker.
/// </summary>
[IsoId("_utoSAVc8EeunQrLahSRvvA")]
[DisplayName("Tracker Status And Transaction")]
public partial record TrackerStatusAndTransaction11
{
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_uuX441c8EeunQrLahSRvvA")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TrackerStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_uuX45Vc8EeunQrLahSRvvA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<TrackerPaymentTransaction10> Transaction { get; init; } = [];
    // ID for the above is _uuX45Vc8EeunQrLahSRvvA
    
    
    #nullable disable
    
}
