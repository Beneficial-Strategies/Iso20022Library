# Headless UI Framework — ISO 20022 Client-Side Strategy

Captured from architectural discussion, 2026-06-08.

---

## Context

The ISO 20022 library is a .NET library maintained server-side. This document explores the
direction of building a **browser-side counterpart** — a TypeScript library that provides
validation, serialization, and UI component behavior for ISO 20022 message entry screens,
usable by any web framework.

---

## Technology Options Evaluated

### Blazor WASM

A Blazor Server demo was built for `pain.001.001.11` (see
`src/BeneficialStrategies.Iso20022.Demo`). The question was whether to publish it as a
portable WASM component embeddable in non-Blazor pages.

**Conclusion: not suitable for standalone embedding.**

Blazor WASM is not "C# compiled to WebAssembly instructions." It is the **.NET runtime
compiled to WASM**, with C# code running on top of it. The dependency on the .NET runtime
does not go away — it moves to the browser. First-load cost is 3–5 MB compressed.

The Custom Elements mechanism (`RegisterCustomElement<T>`) does allow embedding a Blazor
component in any HTML page via a `<iso20022-pain001>` tag, but the consumer still downloads
the .NET runtime.

### Rust + WASM

Rust compiles to genuine WebAssembly bytecode with no runtime dependency.

- `wasm-pack build --target web` produces `module.wasm` + `module.js` (glue) + `module.d.ts`
- The `.d.ts` file gives consuming TypeScript code full IntelliSense — autocomplete, parameter
  names, hover documentation
- Rust doc comments flow through to JSDoc in the generated `.d.ts`
- The `tsify` crate generates TypeScript interfaces from Rust structs, so complex objects
  (not just primitives) cross the boundary with full type information
- The same Rust core library compiles to WASM (browser) and native (server), sharing
  validation and serialization logic between both targets

**The client/server parity argument is strong:** one Rust codebase, same rules everywhere,
no drift between client-side and server-side validation.

**Limitations for this project:**
- The existing .NET ISO 20022 library would need to be rewritten in Rust
- UI component ecosystem integration is awkward (only strings and primitives cross the
  WASM boundary cleanly; framework-native patterns like React hooks are not natural)
- No equivalent of Zod, React hooks, or Vue composables in WASM-land

### TypeScript

**Recommended direction for UI components.**

Pure TypeScript owns the browser-side entirely. The .NET library remains authoritative
server-side. Both are generated from the same ISO 20022 spec, so they describe the same
rules even though they don't share code. Contract tests enforce parity.

**Advantages:**
- Native React and Vue integration (hooks, composables)
- Full npm ecosystem access (Zod for validation, fast-xml-parser, etc.)
- Best-in-class IntelliSense for consumers (native TypeScript, no `.d.ts` generation step)
- Smallest bundle size (~50–200 KB)
- Zod schemas generated from the ISO spec can mirror the .NET format constraints exactly

**Tradeoff:** validation logic is maintained in two places (.NET and TypeScript). Mitigated
by generating both from the same spec metadata via the ISO 20022 MCP server.

---

## WASM Security Clarification

WASM does **not** provide security for sensitive data such as account numbers. It is not a
security boundary. Anyone with browser DevTools can:

- Inspect all values in memory via `Uint8Array` over `WebAssembly.Memory`
- Decompile `.wasm` to readable WebAssembly text format with `wasm2wat`
- Intercept all network calls the WASM makes
- Patch the JS glue file to log inputs and outputs

The rule is unchanged from JavaScript: anything that runs in the browser, the user can see.
Account numbers and credentials belong on the server and should never be sent to the client.

---

## Recommended Architecture: Headless TypeScript Library

### What "Headless" Means

A headless library has **no visual output** — no HTML elements, no CSS, no rendered UI.
It provides behavior and state; the consumer provides all markup and styling.

Traditional component library:
```tsx
// Markup and behavior locked together — limited styling control
<DatePicker value={date} onChange={setDate} />
```

Headless library:
```tsx
// Behavior only — consumer writes all markup
const { value, onChange, isOpen, getDayProps } = useDatePicker();
return (
  <div className={yourStyles.wrapper}>
    <input value={value} onChange={onChange} />
    {isOpen && <div className={yourStyles.calendar}>...</div>}
  </div>
);
```

The analogy: a traditional library is a pre-built desk. A headless library is drawer slides
and hinges — the mechanical parts that make it work, with no opinion on the shape.

### Why Headless for ISO 20022

Financial institutions each have their own design systems. A library that ships visual
components forces every consumer to fight its CSS. A headless library lets Deutsche Bank,
BNP Paribas, and a fintech startup all use the same ISO 20022 validation logic while
rendering it inside their own design systems.

### Proposed Package Structure

```
@iso20022/types       — generated TypeScript interfaces from the ISO spec (no logic)
@iso20022/validate    — Zod schemas, format constraints, IBAN/BIC validation
@iso20022/serialize   — XML and JSON serialization
@iso20022/react       — React hooks + headless form components
@iso20022/vue         — Vue composables + headless form components
@iso20022/elements    — framework-agnostic Web Components via Lit (works everywhere)
```

The top three packages are pure TypeScript with no framework dependency. The framework
packages are thin wrappers that consume them.

### Public API Shape (React)

```typescript
// What the library exports — no JSX, no CSS, no DOM elements
export function usePain001Form(options?: FormOptions): Pain001FormState;
export function useIbanField(value: string): IbanFieldState;
export function useBicField(value: string): BicFieldState;
export function validatePain001(data: Pain001FormData): ValidationResult;
export function serializeToXml(data: Pain001FormData): string;
export function serializeToJson(data: Pain001FormData): string;

export type Pain001FormData = { ... };
export type ValidationResult = { valid: boolean; errors: FieldErrors };
export type FieldErrors = Partial<Record<keyof Pain001FormData, string>>;
```

### Consumer Examples

```tsx
// Bootstrap consumer
<div className="card">
  <input className="form-control" {...getFieldProps('debtorIban')} />
  {errors.debtorIban && <span className="text-danger">{errors.debtorIban}</span>}
</div>

// Tailwind consumer — same hook, completely different markup
<div className="rounded-xl shadow-sm border p-4">
  <input className="w-full border-b focus:outline-none" {...getFieldProps('debtorIban')} />
  {errors.debtorIban && <p className="text-red-500 text-sm mt-1">{errors.debtorIban}</p>}
</div>

// Bank's proprietary design system
<BankTextField {...getFieldProps('debtorIban')} error={errors.debtorIban} />
```

All three use the same hook. The library never touches CSS.

### Responsibility Split

| Library owns | Consumer owns |
|---|---|
| Field validation rules | HTML element choice |
| Format error messages | CSS classes and styles |
| XML/JSON serialization | Layout and spacing |
| ARIA attributes | Color, typography, branding |
| Field interdependencies | Design system integration |
| ISO spec fidelity | Mobile vs desktop behaviour |

### Accessibility

ARIA attributes (`aria-invalid`, `aria-describedby`, `aria-required`) are returned as part
of the field props spread and land on whatever DOM element the consumer chooses:

```typescript
getFieldProps('debtorIban')
// returns:
{
  value: '...',
  onChange: ...,
  onBlur: ...,
  'aria-invalid': true,
  'aria-describedby': 'debtorIban-error',
  'aria-required': true,
}
```

---

## Prior Art: Existing Headless Libraries

| Library | Framework | Notes |
|---|---|---|
| Radix UI | React | Reference implementation. No styles. shadcn/ui wraps it with Tailwind. |
| TanStack Form | React, Vue, Angular, Solid | Form state only, zero markup. Closest architectural analogue. |
| React Aria (Adobe) | React | Most thorough. Separates behavior hooks, ARIA semantics, and visual layer. |
| Headless UI | React, Vue | Tailwind Labs. Clean API, simpler scope than Radix. |
| Floating UI | Any | Positioning logic only for dropdowns and tooltips. No rendering. |
| ING Lion | Web Components (Lit) | Genuine headless library from a bank. Closest existing example in finance. |
| SaltDS (JP Morgan) | React | Open-sourced 2023. Has headless primitives but ships its own visual layer. |
| AG Grid | Any | Headless-ish rendering for data grids. Powers most financial dashboards. |

**The gap:** all of the above are general-purpose. None know what an IBAN is, what BIC
validation means, or how to serialize to ISO 20022 XML. A domain-specific headless library
for ISO 20022 message entry does not exist in the open-source ecosystem.

---

## Web Components as the Standardization Path

If the goal is components that work in React, Vue, Angular, Svelte, and plain HTML without
adaptation, **Lit** (Google's Web Components library) is the leading approach:

```html
<!-- Works in any framework or plain HTML -->
<iso20022-iban-field name="debtorIban"></iso20022-iban-field>
<iso20022-pain001-form></iso20022-pain001-form>
```

Lit is TypeScript-first, produces standard Custom Elements, and ships `.d.ts` files.
Microsoft's Fluent UI and Google's Material Web are built this way.

The `@iso20022/elements` package in the proposed structure above would be the Lit
implementation — enabling use by consumers who are not on React or Vue.

---

## Relationship to the .NET Library

The TypeScript library does not replace the .NET library. The split is:

- **.NET library** — server-side message construction, validation, serialization, all
  ISO 20022 message types, used in back-end payment processing pipelines
- **TypeScript library** — browser-side form behavior, client-side validation, UX for
  message entry screens

Both are generated from the same ISO 20022 spec via the MCP server. The TypeScript Zod
schemas mirror the .NET `Iso20022FormatException` constraints. Contract tests verify parity.

---

## Status

Not started. Captured here as a directional reference for future implementation planning.
