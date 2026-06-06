// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Line item of a telecom services purchase.
/// </summary>
[IsoId("_DK8YkUiEEfCMZJtj4J7UGQ")]
[DisplayName("Telecom Services Line Item4")]
public record TelecomServicesLineItem4
{
    /// <summary>
    /// Contains the start date and time of the phone call.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-stdt")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    public IsoISODate? StartDateTime { get; init; }

    /// <summary>
    /// Describes the period (such as peak or off peak) of the phone call.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-tmpr")]
    [DisplayName("Time Period")]
    [IsoXmlTag("TmPrd")]
    public IsoMax35Text? TimePeriod { get; init; }

    /// <summary>
    /// Duration of phone call expressed in HHMMSS format. 
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-drtn")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoISOTime? Duration { get; init; }

    /// <summary>
    /// Contains call type values for the originator of the telephone call . P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cftp")]
    [DisplayName("Call From Type")]
    [IsoXmlTag("CallFrmTp")]
    public TelephonyCallType2Code? CallFromType { get; init; }

    /// <summary>
    /// Origination  phone number.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cfph")]
    [DisplayName("Call From Phone")]
    [IsoXmlTag("CallFrmPhne")]
    public IsoPhoneNumber? CallFromPhone { get; init; }

    /// <summary>
    /// City from which the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cfcy")]
    [DisplayName("Call From City")]
    [IsoXmlTag("CallFrmCty")]
    public IsoMax35Text? CallFromCity { get; init; }

    /// <summary>
    /// Country sub division major from which the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cfcm")]
    [DisplayName("Call From Country Sub Division Major")]
    [IsoXmlTag("CallFrmCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CallFromCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Country sub division minor from which the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cfcn")]
    [DisplayName("Call From Country Sub Division Minor")]
    [IsoXmlTag("CallFrmCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CallFromCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Country from which  the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cfco")]
    [DisplayName("Call From Country")]
    [IsoXmlTag("CallFrmCtry")]
    public ISOMax3ACountryCode? CallFromCountry { get; init; }

    /// <summary>
    /// Contains call type values for the destination of the telephone call .
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-cttp")]
    [DisplayName("Call To Type")]
    [IsoXmlTag("CallToTp")]
    public TelephonyCallType2Code? CallToType { get; init; }

    /// <summary>
    /// Destination  phone number.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ctph")]
    [DisplayName("Call To Phone")]
    [IsoXmlTag("CallToPhne")]
    public IsoPhoneNumber? CallToPhone { get; init; }

    /// <summary>
    /// City to which the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ctcy")]
    [DisplayName("Call To City")]
    [IsoXmlTag("CallToCty")]
    public IsoMax35Text? CallToCity { get; init; }

    /// <summary>
    /// Country sub division major to which the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ctcm")]
    [DisplayName("Call To Country Sub Division Major")]
    [IsoXmlTag("CallToCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CallToCountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Country sub division minor to which the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ctcn")]
    [DisplayName("Call To Country Sub Division Minor")]
    [IsoXmlTag("CallToCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CallToCountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Country to which  the call was made.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ctco")]
    [DisplayName("Call To Country")]
    [IsoXmlTag("CallToCtry")]
    public ISOMax3ACountryCode? CallToCountry { get; init; }

    /// <summary>
    /// Contains the amount pertaining to the telephony billing event.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-chrg")]
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public ValueList<TelecomLineItemAmount1> Charge { get; init; } = [];

    /// <summary>
    /// Total of taxes applicable to the billing amount of the telephone call.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-tax0")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Total amount includes amounts of all charge types and total tax amounts.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ttla")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Description of the telecommunications services line item details
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-dsc")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax256Text? Description { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_DK8YkUiEEfCMZJtj4J7UGQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
