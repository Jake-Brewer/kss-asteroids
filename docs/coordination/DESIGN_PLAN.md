# Kss-Asteroids Unity Game Design & Feature Checklist

(See README.md for project overview)

## High-Level Feature List
- [ ] [F1] Player Ship Movement *(Complete when all of: [F1.1], [F1.2], [F1.3] are checked)*
- [ ] [F2] Player Shooting (Bullets)
- [ ] [F3] Asteroid Spawning
- [ ] [F4] Asteroid Splitting
- [ ] [F5] Asteroid & Bullet Collision
- [ ] [F6] Ship & Asteroid Collision (Lives)
- [ ] [F7] Scoring System
- [ ] [F8] Game Over & Restart
- [ ] [F9] UI: Score, Lives, Game Over
- [ ] [F10] Sound Effects (shoot, explosion)
- [ ] [F11] Visual Polish (sprites, particles)
- [ ] [F12] GitHub Integration

---

## Feature Designs & Implementation Steps

### 1. Player Ship Movement [F1]
- **Design:** Ship rotates left/right, thrusts forward, and wraps around screen edges.
- **Steps:**
  - [x] [F1.1] Script for input-based rotation/thrust
  - [x] [F1.2] Rigidbody2D for physics
  - [x] [F1.3] Screen wrap logic

### 2. Player Shooting (Bullets) [F2]
- **Design:** Player fires bullets in facing direction; bullets have limited lifetime.
- **Steps:**
  - [x] [F2.1] Bullet prefab and script
  - [x] [F2.2] Instantiate on key press
  - [x] [F2.3] Bullet lifetime & destruction

### 3. Asteroid Spawning [F3]
- **Design:** Spawn asteroids at random positions away from player at game start.
- **Steps:**
  - [x] [F3.1] Asteroid prefab and script
  - [x] [F3.2] Random spawn logic in GameManager

### 4. Asteroid Splitting [F4]
- **Design:** Large asteroids split into smaller ones when shot, down to minimum size.
- **Steps:**
  - [x] [F4.1] Size property on Asteroid
  - [x] [F4.2] Split logic on bullet collision

### 5. Asteroid & Bullet Collision [F5]
- **Design:** Destroy both asteroid and bullet on collision; split if applicable.
- **Steps:**
  - [x] [F5.1] Collision detection
  - [x] [F5.2] Asteroid splitting/spawn

### 6. Ship & Asteroid Collision (Lives) [F6]
- **Design:** Player loses a life on collision; respawn or game over if out of lives.
- **Steps:**
  - [ ] [F6.1] Detect collision
  - [ ] [F6.2] Manage lives/game over

### 7. Scoring System [F7]
- **Design:** Player gains points for destroying asteroids (more for smaller ones).
- **Steps:**
  - [ ] [F7.1] Score variable
  - [ ] [F7.2] Add points on asteroid destruction
  - [ ] [F7.3] Display on UI

### 8. Game Over & Restart [F8]
- **Design:** Game ends when lives reach zero; option to restart.
- **Steps:**
  - [ ] [F8.1] Game over logic
  - [ ] [F8.2] Restart input

### 9. UI: Score, Lives, Game Over [F9]
- **Design:** Simple text UI for score, lives, and game over message.
- **Steps:**
  - [ ] [F9.1] Add Unity UI elements
  - [ ] [F9.2] Update via script
  - [ ] [F9.3] Minimal UI for first runnable build

### 10. Sound Effects [F10]
- **Design:** Play sounds for shooting, explosions, and game events.
- **Steps:**
  - [ ] [F10.1] Import SFX assets
  - [ ] [F10.2] Play via script

### 11. Visual Polish [F11]
- **Design:** Use creative commons sprites, add simple particles for effects.
- **Steps:**
  - [ ] [F11.1] Import/assign sprites
  - [ ] [F11.2] Add particles (optional)

### 12. GitHub Integration [F12]
- **Design:** Project is version-controlled and pushed to GitHub.
- **Steps:**
  - [x] [F12.1] .gitignore
  - [x] [F12.2] Initial commit
  - [x] [F12.3] Push to GitHub

### Project Automation & Quality Controls
- [x] [A1] Make the repo public
- [ ] [A2] Set up branch protection rules for dev and master
  - **Notes:**
    - [A2.1] Production branch is named `master`.
    - [A2.2] 422 error from GitHub CLI: "required_pull_request_reviews", "required_status_checks" weren't supplied (API call must match docs exactly).
    - [A2.3] Will retry with correct parameters and document results here.
- [ ] [A3] Set up PR automation for auto-merge after CI passes (no human approval required, if possible)
- [ ] [A4] Add Unity build and playmode test steps to CI
- [ ] [A5] Add markdown linting to CI (block merges if markdown lint fails)
- [ ] [A6] Set up GitHub notifications for project alerts
- [ ] [A7] Add local git pre-push hook to warn on markdown lint errors
- [ ] [A8] Add local pre-commit/push hooks on master to prevent direct pushes
- [ ] [A9] Add Unity test scripts (editmode and playmode) and run in CI
- [ ] [A10] Remove MIT license file and ensure no license is applied
- [ ] [A11] Check for permissions before reporting a block
- [ ] [A12] Update DESIGN_PLAN.md and docs as work progresses
- [ ] [A13] Push early and often to the appropriate branch
- [ ] [A14] Push Unity build to GitHub Actions for web deployment

### Design Documentation
- [ ] [D1] Generate and commit feature diagrams (docs/designs/)
- [ ] [D2] Generate and commit class diagrams (docs/designs/)
- [ ] [D3] Generate and commit UI wireframes (docs/designs/)

### Linting & Testing
- [ ] [L1] Add markdown linting to CI
- [ ] [L2] Add markdown linting to local pre-commit warning hook
- [ ] [L3] Add markdown linting to local pre-push hook on dev
- [ ] [L4] Add pre-push and pre-commit hooks on master to block pushes and instruct to use dev
- [ ] [L5] Document all files with markdown lint errors for future fixes

---

## Quality Controls Before Merging to Master
- [ ] [QC1] CI must pass (lint, build, tests)
- [ ] [QC2] PR review required (automated if possible)
- [ ] [QC3] No direct pushes to master
- [ ] [QC4] All feature branches must be up-to-date with dev before merge

---

## Execution Order & Priorities
- [P1] **Execution will proceed in the order of the checklist unless otherwise specified.**
- [P2] **Features F1-F11 are always-priority; at least one subtask from these will be worked on in every reply.**
- [P3] **A2 (branch protection) is the current active automation task.**
- [P4] **Checklist will be updated immediately as tasks are completed.**

---

## Notes
- Always address lint errors immediately when markdown linting is enforced.
- Use `git add . ; git commit -m "..." ; git push` (semicolon for PowerShell compatibility)
- Review and approve PRs via GitHub UI (Cascade cannot directly approve PRs, but can provide review comments and guidance)
- For UI/UX mockups or additional design, request as needed.
- Attribution for assets will be tracked in CREDITS.txt.
- Checklist will be updated as features are completed or revised.
- Subtasks and additional features will be added as needed.
