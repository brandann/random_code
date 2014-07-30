import pygame
from pygame import *

class Player(pygame.sprite.Sprite):
    def __init__(self, down):
        self.x = 200 #initial position
        self.y = 50  #initial position
        
        self.move_rate_init = 5 #image change rate
        self.move_rate = self.move_rate_init  #image change count
        
        self.ani_down = down
        self.ani_up = None
        self.ani_left = None
        self.ani_right = None
        self.ani = self.ani_down #initial image
        
        self.ani_pos = 0
        self.ani_max = len(self.ani) - 1
        self.img = pygame.image.load(self.ani[0])
        self.update(0,0,'D')
        
    
    def update(self, dx, dy, dir):
        if dir == 'U':
            self.ani = self.ani_up
        elif dir == 'D':
            self.ani = self.ani_down
        elif dir == 'R':
            self.ani = self.ani_right
        elif dir == 'L':
            self.ani = self.ani_left
        if dx or dy != 0:
            self.move_rate -= 1
            if self.move_rate == 0:
                self.img = pygame.image.load(self.ani[self.ani_pos])
                self.move_rate = self.move_rate_init
                if dx != 0:
                    self.move_single_axis(dx, 0)
                if dy != 0:
                    self.move_single_axis(0, dy)
                if self.ani_pos == self.ani_max:
                    self.ani_pos = 1
                else:
                    self.ani_pos += 1
        #else:
            #self.ani_pos = 0
            #self.img = pygame.image.load(self.ani[self.ani_pos])
        screen.blit(self.img,(self.x,self.y))
    
    def move_single_axis(self, dx, dy):
        self.x += dx
        self.y += dy
    
    def set_image(up, down, left, right):
      self.ani_up = up
      self.ani_down = down
      self.ani_left = left
      self.ani_right = right