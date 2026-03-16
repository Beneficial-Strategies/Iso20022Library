// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trigger parameters.
/// </summary>
[IsoId("_99Ns1nltEeG7BsjMvd1mEw_340413416")]
[DisplayName("Trigger")]
public record Trigger1
{
    /// <summary>
    /// Details related to the date on which a variation is effective.
    /// </summary>
    [IsoId("_99Ns13ltEeG7BsjMvd1mEw_-1029546391")]
    [DisplayName("Date Choice")]
    [IsoXmlTag("DtChc")]
    public FixedOrRecurrentDate1Choice_? DateChoice { get; init; }

    /// <summary>
    /// Details related to the documentary event on which a variation is triggered.
    /// </summary>
    [IsoId("_99Ns2HltEeG7BsjMvd1mEw_-1230694624")]
    [DisplayName("Documentary Event")]
    [IsoXmlTag("DcmntryEvt")]
    public ValueList<Document10> DocumentaryEvent { get; init; } = [];
}
