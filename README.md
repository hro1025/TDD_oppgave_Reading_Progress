# Reading Progress Tracker — TDD Assignment

> **Disclaimer**
>
> This assignment was custom-created by ChatGPT as a personal learning exercise.
>
> The requirements, scope, and evaluation criteria are defined **exclusively** in this README.
>
> ChatGPT will act as the grader, and the submission will be evaluated **only** against the criteria described here.
>
> No external rubrics, expectations, or implied requirements apply.

## ✅ Final Verdict (Grading)

**Status:** ✔ Correct  
**Final Grade:** ⭐ **10 / 10**

This submission has been evaluated **strictly against the criteria defined in this README**.

### Evaluation Summary

- ✔ **Test-Driven Development (Red → Green → Refactor)** was followed correctly  
- ✔ A **single evolving domain model** (`ReadingProgress`) was used  
- ✔ Tests **drove the design**, not the implementation  
- ✔ Required scenarios were covered:
  - 0% progress
  - 50% progress
  - One explicit **edge case**, tested first with intentional behavior
- ✔ Hardcoded logic was **intentionally introduced and later removed through refactoring**
- ✔ Refactoring preserved behavior while improving design
- ✔ The solution remained **pure domain logic** with no UI or external concerns

### Verdict

The submission fully satisfies the assignment’s learning goals and constraints.  
No criteria were violated, and no required elements are missing.

This is a **complete and correct TDD submission**.

*Graded by ChatGPT according to the criteria defined in this README.*
---

## Overview

This assignment focuses on learning **Test-Driven Development (TDD)** by building a small, isolated **domain model** step by step.

The goal is **not** to build a complete application, but to experience how **design emerges through tests** using the  
**Red → Green → Refactor** cycle.

---

## Learning Goals

- Practice writing tests **before** implementation
- Let tests **drive the design**
- Keep the domain small, isolated, and expressive
- Refactor safely with tests as a safety net

---

## Scope & Constraints

### In scope (graded)
- Pure **domain logic**
- Unit tests
- TDD workflow

### Out of scope (not graded)
- UI
- Console input/output
- Database
- Framework-specific code

> Any UI (including console applications) must be kept **separate** from the domain model.

---

## Domain Problem

You will model a small part of a system that answers the question:

> **“How far along am I in this book?”**

The system should calculate **reading progress as a percentage (0–100)** based on:
- Pages read
- Total pages

---

## Assignment Steps

### Part 1 — Formulate the First Hypothesis

Create a domain class called `ReadingProgress`.

Do **not** design it upfront.  
Start by writing a test.

---

### Part 2 — First Experiment (Red)

**Hypothesis:**  
If `0` pages of a book have been read, the progress should be `0%`.

- Write one test that expresses this behavior
- Run the test and confirm that it fails

---

### Part 3 — Minimal Implementation (Green)

- Implement **just enough code** to make the test pass
- Do not add extra functionality
- Avoid guessing future requirements

---

### Part 4 — Refactor

- Improve clarity, naming, or structure
- Do not change behavior
- All tests must remain green

---

### Part 5 — New Hypothesis

**Hypothesis:**  
If half of the book has been read, the progress should be `50%`.

- Write a new test **against the same domain model**
- Let the new test force changes to the existing design
- Repeat the Red → Green → Refactor cycle

---

### Part 6 — Edge Case Exploration

Choose **one** of the following scenarios:

- Total pages = `0`
- Pages read > total pages
- Pages read < `0`

For the chosen case:
- Write the test first
- Decide how the system should behave
- Adjust the domain model accordingly

There is no single “correct” answer — only a **consistent, well-tested decision**.

---

## Optional (Not Graded)

After the domain logic is complete and fully tested, you may create a **simple console application** that:

- Reads user input (pages read, total pages)
- Uses the `ReadingProgress` domain class
- Prints the calculated progress

The console app must not contain business logic.

---

## Success Criteria

You have completed the assignment when:

- Tests were written **before** implementation
- A **single domain model** evolved through tests
- No hardcoded values are tied to specific test cases
- One edge case is explicitly tested
- The domain logic can exist independently of any UI
