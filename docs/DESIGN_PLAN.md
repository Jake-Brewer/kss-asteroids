# Kss-Asteroids Unity Game Design & Feature Checklist

(See README.md for project overview)

## High-Level Feature List
- [ ] Player Ship Movement
- [ ] Player Shooting (Bullets)
- [ ] Asteroid Spawning
- [ ] Asteroid Splitting
- [ ] Asteroid & Bullet Collision
- [ ] Ship & Asteroid Collision (Lives)
- [ ] Scoring System
- [ ] Game Over & Restart
- [ ] UI: Score, Lives, Game Over
- [ ] Sound Effects (shoot, explosion)
- [ ] Visual Polish (sprites, particles)
- [ ] GitHub Integration

---

## Feature Designs & Implementation Steps

### 1. Player Ship Movement
- **Design:** Ship rotates left/right, thrusts forward, and wraps around screen edges.
- **Steps:**
  - [x] Script for input-based rotation/thrust
  - [x] Rigidbody2D for physics
  - [x] Screen wrap logic

### 2. Player Shooting (Bullets)
- **Design:** Player fires bullets in facing direction; bullets have limited lifetime.
- **Steps:**
  - [x] Bullet prefab and script
  - [x] Instantiate on key press
  - [x] Bullet lifetime & destruction

### 3. Asteroid Spawning
- **Design:** Spawn asteroids at random positions away from player at game start.
- **Steps:**
  - [x] Asteroid prefab and script
  - [x] Random spawn logic in GameManager

### 4. Asteroid Splitting
- **Design:** Large asteroids split into smaller ones when shot, down to minimum size.
- **Steps:**
  - [x] Size property on Asteroid
  - [x] Split logic on bullet collision

### 5. Asteroid & Bullet Collision
- **Design:** Destroy both asteroid and bullet on collision; split if applicable.
- **Steps:**
  - [x] Collision detection
  - [x] Asteroid splitting/spawn

### 6. Ship & Asteroid Collision (Lives)
- **Design:** Player loses a life on collision; respawn or game over if out of lives.
- **Steps:**
  - [ ] Detect collision
  - [ ] Manage lives/game over

### 7. Scoring System
- **Design:** Player gains points for destroying asteroids (more for smaller ones).
- **Steps:**
  - [ ] Score variable
  - [ ] Add points on asteroid destruction
  - [ ] Display on UI

### 8. Game Over & Restart
- **Design:** Game ends when lives reach zero; option to restart.
- **Steps:**
  - [ ] Game over logic
  - [ ] Restart input

### 9. UI: Score, Lives, Game Over
- **Design:** Simple text UI for score, lives, and game over message.
- **Steps:**
  - [ ] Add Unity UI elements
  - [ ] Update via script

### 10. Sound Effects
- **Design:** Play sounds for shooting, explosions, and game events.
- **Steps:**
  - [ ] Import SFX assets
  - [ ] Play via script

### 11. Visual Polish
- **Design:** Use creative commons sprites, add simple particles for effects.
- **Steps:**
  - [ ] Import/assign sprites
  - [ ] Add particles (optional)

### 12. GitHub Integration
- **Design:** Project is version-controlled and pushed to GitHub.
- **Steps:**
  - [x] .gitignore
  - [ ] Initial commit
  - [ ] Push to GitHub

---

## Notes
- Attribution for assets will be tracked in CREDITS.txt.
- Checklist will be updated as features are completed or revised.
- Subtasks and additional features will be added as needed.
