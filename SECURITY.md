# Security Policy

## Reporting a Vulnerability

If you discover a security vulnerability in TypedMath, please report it privately:

1. **Do NOT** open a public GitHub issue
2. Email security concerns to: **security@marcusmedina.pro**
3. Include:
   - Detailed description of the vulnerability
   - Steps to reproduce the issue
   - Potential impact assessment
   - Suggested fix (if available)
4. Allow reasonable time for response (72 hours)

We take security seriously and will respond promptly to all reports.

---

## Supported Versions

| Version | Supported          | Status |
| ------- | ------------------ | ------ |
| 2.x     | ✅ Active support  | Current stable release |
| 1.x     | ⚠️ Limited support | Security fixes only |
| < 1.0   | ❌ Not supported   | End of life |

---

## Security Best Practices

When using TypedMath in your projects:

### For Library Users
- ✅ Keep dependencies updated (`dotnet list package --outdated`)
- ✅ Use latest .NET 8 runtime with security patches
- ✅ Follow secure coding practices in your implementations
- ✅ Validate all user inputs before mathematical operations
- ✅ Be aware of potential overflow/underflow in calculations

### For Contributors
- ✅ Never commit secrets, API keys, or credentials
- ✅ Run security scans before submitting PRs
- ✅ Follow the [CONTRIBUTING.md](CONTRIBUTING.md) guidelines
- ✅ Report suspicious code patterns during code review

---

## Known Security Considerations

### Mathematical Operations
- **Integer Overflow**: TypedMath performs standard .NET arithmetic operations which can overflow. Use checked contexts if overflow protection is required.
- **Division by Zero**: Methods like `DividedBy()` can throw `DivideByZeroException`. Validate divisors in your code.
- **Casting Precision Loss**: Type conversion methods may lose precision when casting between types (e.g., `double` to `int`).

### Array Operations
- **Index Out of Range**: Array methods assume valid array sizes. Validate inputs before use.
- **Performance**: Some array operations create new arrays. Be mindful of memory usage in performance-critical scenarios.

---

## Security Update Policy

### Critical Vulnerabilities
- **Response Time**: Within 24 hours
- **Patch Release**: Within 7 days
- **Public Disclosure**: After patch is available

### High Severity
- **Response Time**: Within 72 hours
- **Patch Release**: Within 14 days

### Medium/Low Severity
- **Response Time**: Within 1 week
- **Patch Release**: Next minor/major version

---

## Security Contacts

- **Primary**: security@marcusmedina.pro
- **Author**: Marcus Medina
- **GitHub**: [@MarcusMedina](https://github.com/MarcusMedina)

---

## Acknowledgments

We appreciate security researchers who responsibly disclose vulnerabilities. Contributors will be acknowledged in:
- CHANGELOG.md release notes
- GitHub Security Advisories
- Project documentation

---

Thank you for helping keep TypedMath secure! 🔒

**Last Updated**: 2025-01-18
