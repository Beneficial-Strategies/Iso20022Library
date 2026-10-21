// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>What the message records of the <c>Common</c> package write for one pacs.029 message, kept as text so that these tests need no records:
/// the interfaces must read and write the same XML and the same JSON.</summary>
internal static class Golden
{
    internal const string Xml = """
<Document xmlns="urn:iso:std:iso:20022:tech:xsd:pacs.029.001.02">
  <MulSttlmReq>
    <GrpHdr>
      <MsgId>MSG-001</MsgId>
      <CreDtTm>2026-01-01T00:00:00</CreDtTm>
      <NbOfSttlmReqs>1</NbOfSttlmReqs>
    </GrpHdr>
    <SttlmReq>
      <InstrId>INSTR-001</InstrId>
      <MvmntRcrd>
        <Id>MOV-001</Id>
        <Amt>
          <Amt Ccy="EUR">100</Amt>
        </Amt>
      </MvmntRcrd>
      <MvmntRcrd>
        <Id>MOV-002</Id>
        <Amt>
          <Amt Ccy="EUR">200</Amt>
        </Amt>
      </MvmntRcrd>
    </SttlmReq>
  </MulSttlmReq>
</Document>
""";

    internal const string Json = """
{"group_header":{"message_identification":"MSG-001","creation_date_time":"2026-01-01T00:00:00","number_of_settlement_requests":"1","control_sum":null,"settlement_information":null},"settlement_request":[{"instruction_identification":"INSTR-001","instruction_priority":null,"settlement_time_request":null,"settlement_priority":null,"settlement_cycle":null,"number_of_movement_records":null,"movement_record":[{"identification":"MOV-001","sequence_number":null,"amount":{"amount":{"currency":"EUR","amount":"100"},"credit_debit":null},"settlement_agent":null,"settlement_agent_account":null,"participant":null,"participant_account":null,"reference":null},{"identification":"MOV-002","sequence_number":null,"amount":{"amount":{"currency":"EUR","amount":"200"},"credit_debit":null},"settlement_agent":null,"settlement_agent_account":null,"participant":null,"participant_account":null,"reference":null}]}],"supplementary_data":null}
""";
}
