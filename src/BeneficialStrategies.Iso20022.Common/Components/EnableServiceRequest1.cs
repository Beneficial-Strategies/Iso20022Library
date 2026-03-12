// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request to enable a service.
/// </summary>
[IsoId("_afs4oNuSEeiB5uLfkg9ZJA")]
[DisplayName("Enable Service Request")]
public partial record EnableServiceRequest1
{
    #nullable enable
    
    /// <summary>
    /// Action to realise on a transaction.
    /// </summary>
    [IsoId("_hEATINuSEeiB5uLfkg9ZJA")]
    [DisplayName("Transaction Action")]
    [IsoXmlTag("TxActn")]
    public required TransactionAction1Code TransactionAction { get; init; } 
    
    /// <summary>
    /// Services enabled before the start-up of a transaction.
    /// </summary>
    [IsoId("_UnZWkNuUEeiB5uLfkg9ZJA")]
    [DisplayName("Services Enabled")]
    [IsoXmlTag("SvcsNbld")]
    public RetailerService2Code? ServicesEnabled { get; init; } 
    
    /// <summary>
    /// Prompt or welcome message.
    /// </summary>
    [IsoId("_LSnpcNudEeiB5uLfkg9ZJA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage6? DisplayOutput { get; init; } 
    
    
    #nullable disable
    
}
