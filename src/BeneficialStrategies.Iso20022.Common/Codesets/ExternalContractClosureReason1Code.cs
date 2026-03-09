// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a contract closure reason code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9dPfkQrAEeWD-cmAqruRjw")]
[Description(@"Specifies a contract closure reason code, as published in the external ISO 20022 external code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalContractClosureReasonCode))]
public enum ExternalContractClosureReason1Code
{
    /// <summary>
    /// The parties have fulfilled all liabilities under the contract (loan agreement), including fulfillment of the liabilities by a resident third party (by another resident party).
    /// Encoded/decoded by serializers as &quot;PCED&quot;.
    /// </summary>
    [EnumMember(Value = "PCED")]
    [IsoId("_uTwFdfRYEeuLhpyIdtJzwg")]
    [Description(@"The parties have fulfilled all liabilities under the contract (loan agreement), including fulfillment of the liabilities by a resident third party (by another resident party).")]
    CompletedContract = ExternalContractClosureReasonCode.CompletedContract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// If the liabilities under the contract (loan agreement) are fulfilled (stopped) on other grounds, not mentioned in the currency control regulation.
    /// Encoded/decoded by serializers as &quot;POTR&quot;.
    /// </summary>
    [EnumMember(Value = "POTR")]
    [IsoId("_uTwFePRYEeuLhpyIdtJzwg")]
    [Description(@"If the liabilities under the contract (loan agreement) are fulfilled (stopped) on other grounds, not mentioned in the currency control regulation.")]
    OtherReasonsThatTheLiabilitiesOfTheContractAreFufilled = ExternalContractClosureReasonCode.OtherReasonsThatTheLiabilitiesOfTheContractAreFufilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// At the termination of the grounds (under the regulation) require the registered contract to be issued, including the cases resulting from making the appropriate changes and (or) additions to the contract (loan agreement), or if the registered contract has been wrongly issued in the absence in the contract (loan agreement) of any grounds for its issuance.
    /// Encoded/decoded by serializers as &quot;PRNR&quot;.
    /// </summary>
    [EnumMember(Value = "PRNR")]
    [IsoId("_uTwFe_RYEeuLhpyIdtJzwg")]
    [Description(@"At the termination of the grounds (under the regulation) require the registered contract to be issued, including the cases resulting from making the appropriate changes and (or) additions to the contract (loan agreement), or if the registered contract has been wrongly issued in the absence in the contract (loan agreement) of any grounds for its issuance.")]
    ContractRegistrationNotRequired = ExternalContractClosureReasonCode.ContractRegistrationNotRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The resident cedes a claim under the contract (loan agreement) to another resident  party, or transfers a debt under the contract (loan agreement) to another resident  party.
    /// Encoded/decoded by serializers as &quot;PSBT&quot;.
    /// </summary>
    [EnumMember(Value = "PSBT")]
    [IsoId("_uTwFfvRYEeuLhpyIdtJzwg")]
    [Description(@"The resident cedes a claim under the contract (loan agreement) to another resident  party, or transfers a debt under the contract (loan agreement) to another resident  party.")]
    PartyCedesAClaimOrTransfersADebtToAnotherResidentParty = ExternalContractClosureReasonCode.PartyCedesAClaimOrTransfersADebtToAnotherResidentParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The resident cedes a claim under the contract (loan agreement) to a non-resident.
    /// Encoded/decoded by serializers as &quot;PSNR&quot;.
    /// </summary>
    [EnumMember(Value = "PSNR")]
    [IsoId("_uT52cvRYEeuLhpyIdtJzwg")]
    [Description(@"The resident cedes a claim under the contract (loan agreement) to a non-resident.")]
    PartySubsitutedRegistrationIsNotRequired = ExternalContractClosureReasonCode.PartySubsitutedRegistrationIsNotRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The registered contract has been transferred from the bank together with the transfer of the underlying contract (loan agreement) for servicing to another authorised bank (to another affiliate of this authorised bank, from the head office to an affiliate of this authorised bank, or from an affiliate to the head office of this authorised bank), as well as if the resident closes all settlement accounts in the bank of the registered contract.
    /// Encoded/decoded by serializers as &quot;PTAA&quot;.
    /// </summary>
    [EnumMember(Value = "PTAA")]
    [IsoId("_uT52dfRYEeuLhpyIdtJzwg")]
    [Description(@"The registered contract has been transferred from the bank together with the transfer of the underlying contract (loan agreement) for servicing to another authorised bank (to another affiliate of this authorised bank, from the head office to an affiliate of this authorised bank, or from an affiliate to the head office of this authorised bank), as well as if the resident closes all settlement accounts in the bank of the registered contract.")]
    TransferredToAnotherRegistrationAgentOrAllAccountsClosed = ExternalContractClosureReasonCode.TransferredToAnotherRegistrationAgentOrAllAccountsClosed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All customer&apos;s accounts are closed: In the case the resident closes all settlement accounts at the bank where the contract was registered  without closing the registered contract according to the regulation, the bank  shall be entitled to independently close the registered contract after the expiration of 30 working days following the date of closing of the settlement account (last settlement account) of the resident.
    /// Encoded/decoded by serializers as &quot;RACC&quot;.
    /// </summary>
    [EnumMember(Value = "RACC")]
    [IsoId("_uT52ePRYEeuLhpyIdtJzwg")]
    [Description(@"All customer's accounts are closed: In the case the resident closes all settlement accounts at the bank where the contract was registered  without closing the registered contract according to the regulation, the bank  shall be entitled to independently close the registered contract after the expiration of 30 working days following the date of closing of the settlement account (last settlement account) of the resident.")]
    AllAccountsClosed = ExternalContractClosureReasonCode.AllAccountsClosed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// If the bank has all information available for the closing of the registered contract, and all liabilities under the contract (loan agreement) have been fulfilled (terminated), while the resident has not filled an application for closing the registered contract.
    /// Encoded/decoded by serializers as &quot;RCED&quot;.
    /// </summary>
    [EnumMember(Value = "RCED")]
    [IsoId("_uT52e_RYEeuLhpyIdtJzwg")]
    [Description(@"If the bank has all information available for the closing of the registered contract, and all liabilities under the contract (loan agreement) have been fulfilled (terminated), while the resident has not filled an application for closing the registered contract.")]
    AllContractliabilitieshavebeenfulfilledbytheRegistrationAgent = ExternalContractClosureReasonCode.AllContractliabilitieshavebeenfulfilledbytheRegistrationAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In case of failure (on the basis of the information available in the registered contracts data base at the bank) of all obligations under the contract (loan agreement), and failure to provide by a resident of the documents and information (under the regulation), based on which the registered agent conducts a statement of banking supervision, within 180 calendar days following the date specified in the specified section (for example column 6 of Section 3 for Russia) of the registered contract.|In the case referred to in this paragraph, the bank informs  (at its discretion) the resident about the closure of the registered contract not later than in two working days after the date of its closure.
    /// Encoded/decoded by serializers as &quot;REXP&quot;.
    /// </summary>
    [EnumMember(Value = "REXP")]
    [IsoId("_uUDncvRYEeuLhpyIdtJzwg")]
    [Description(@"In case of failure (on the basis of the information available in the registered contracts data base at the bank) of all obligations under the contract (loan agreement), and failure to provide by a resident of the documents and information (under the regulation), based on which the registered agent conducts a statement of banking supervision, within 180 calendar days following the date specified in the specified section (for example column 6 of Section 3 for Russia) of the registered contract.|In the case referred to in this paragraph, the bank informs  (at its discretion) the resident about the closure of the registered contract not later than in two working days after the date of its closure.")]
    RegistrationExpired = ExternalContractClosureReasonCode.RegistrationExpired, // same ordinal as derivation source for type conversions
    
}
